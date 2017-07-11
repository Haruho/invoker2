#region 模块信息
// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             CustomInput.cs
// 作者(Author):                  #AuthorName#
// 创建时间(CreateTime):           #CreateTime#
// 修改者列表(modifier):
// 模块描述(Module description): 自定义按键输入
// **********************************************************************
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class CustomInput : MonoBehaviour{
    //按键
    public List<KeyCode> keys;
    //按键对应的按钮
    public List<Button> buttons;
    public static CustomInput instance;


    //是否处于修改按键的状态
    private bool isChanging = false;
    //修改的按键的索引
    private int keyIndex;

    private void Awake()
    {
        instance = this;
    }
    /// <summary>
    /// 点击按钮的函数
    /// </summary>
    public void OnPointerClick()
    {
        EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text = "Enter Pls...";
        keyIndex = buttons.IndexOf(EventSystem.current.currentSelectedGameObject.GetComponent<Button>());
        isChanging = true;
    }
    private void Start()
    {
        keys.Add(KeyCode.W);
        keys.Add(KeyCode.E);
        keys.Add(KeyCode.R);
        keys.Add(KeyCode.F);
        keys.Add(KeyCode.Q);
        keys.Add(KeyCode.D);
        //修改按钮的Text
        for (int i = 0;i<buttons.Count;i++)
        {
            buttons[i].GetComponentInChildren<Text>().text = keys[i].ToString();
            buttons[i].onClick.AddListener(OnPointerClick);
            
        }
    }
    void Update () {
        //检查按键
        if (Input.anyKeyDown)
        {
       //     InputCheaking();
        }
    }
    /// <summary>
    /// 循环一个存放Keycode的list
    /// </summary>
    void InputCheaking()
    {
        for (int i = 0; i<keys.Count;i++)
        {
            if (Input.GetKeyDown(keys[i]))
            {
                print("Press " + keys[i].ToString());
            }
        }
    }
    private void OnGUI()
    {
        if (isChanging)
        {
            if (Input.anyKeyDown)
            {
                //event只在OnGui（）中才好使
                Event e = Event.current;
                if (e.isKey)
                {
                    //判断是不是已经绑定了按键
                    if (keys.Contains(e.keyCode))
                    {
                       // print("此按键已经绑定");
                       //绑定了的话不做任何修改
                        keys[keyIndex] = keys[keyIndex];
                        EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text = keys[keyIndex].ToString();
                    }
                    else
                    {
                        //修改文字
                        EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text = e.keyCode.ToString();
                        //修改Keycode
                        keys[keyIndex] = e.keyCode;
                    }
                    //状态
                    isChanging = false;
                }
            }
        }
    }
}
