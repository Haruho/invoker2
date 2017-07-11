#region 模块信息
// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             SkillSet.cs
// 作者(Author):                  #zch#
// 创建时间(CreateTime):           #2017/7/10#
// 修改者列表(modifier):
// 模块描述(Module description):实现技能组合
// **********************************************************************
#endregion
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillSet : MonoBehaviour {
    public Image[] currentElements = new Image[3];
    public Image qust;
    public Image wex;
    public Image exort;
	// Use this for initialization
	void Start () {
        for (int i = 0;i<currentElements.Length;i++)
        {
           // currentElements[i].color = new Color(1,1,1,0);
            currentElements[i].sprite = null;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            GetInput();
        }
	}
    void GetInput()
    {
        //获取按钮中的前三个技能按钮
        //也就是基础的元素
        for (int i = 0; i < 3; i++)
        {
            switch (i)
            {
            }
        }
    }
}
