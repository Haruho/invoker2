#region 模块信息
// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             ShowInoutChange.cs
// 作者(Author):                  #AuthorName#
// 创建时间(CreateTime):           #CreateTime#
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************
#endregion
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowInoutChange : MonoBehaviour {
    public GameObject inputChange;
    public Button button;
	// Use this for initialization
	void Start () {
        //print(inputChange.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowHide()
    {
        if (inputChange.transform.position.x>0)
        {
            button.GetComponentInChildren<Text>().text = "改建";
            inputChange.transform.position = new Vector3(-160,92.5f,0);
        }
        else
        {
            button.GetComponentInChildren<Text>().text = "确认";
            inputChange.transform.position = new Vector3(160, 92.5f, 0);
        }
    }
}
