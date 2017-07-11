#region 模块信息
// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             Gobol.cs
// 作者(Author):                  #zch#
// 创建时间(CreateTime):           #2017.7.11#
// 修改者列表(modifier):
// 模块描述(Module description):这个类存放所有技能图标,以及处理用户的元素组合
// **********************************************************************
#endregion
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour {
    public List<Sprite> combiedSkill;
    public static Global instance;
    private void Awake()
    {
        instance = this;
    }
    public Sprite SkillConfirm(string skillName)
    {
        Sprite s = null ;
        switch (skillName)
        {
            case "jslq":
                s = combiedSkill[0];
                break;
            case "bingqiang":
                s = combiedSkill[1];
                break;
            case "ylmb":
                s = combiedSkill[2];
                break;
            case "cibao":
                s = combiedSkill[3];
                break;
            case "ldxj":
                s = combiedSkill[4];
                break;
            case "tianhuo":
                s = combiedSkill[5];
                break;
            case "huoren":
                s = combiedSkill[6];
                break;
            case "chuifeng":
                s = combiedSkill[7];
                break;
            case "yunshi":
                s = combiedSkill[8];
                break;
            case "chaoshengbo":
                s = combiedSkill[9];
                break;
        }
        return s;
    }
}
