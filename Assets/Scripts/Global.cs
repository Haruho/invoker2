#region 模块信息
// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             Gobol.cs
// 作者(Author):                  #zch#
// 创建时间(CreateTime):           #2017.7.11#
// 修改者列表(modifier):                zch
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
    //弃用
    /*
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
    */

     /// <summary>
     /// 根据冰雷火三个元素的数量获取技能图标
     /// </summary>
     /// <param name="bing">冰的数量</param>
     /// <param name="lei">雷的数量</param>
     /// <param name="huo">火的数量</param>
     /// <returns></returns>
    public Sprite getSkillSprite(int bing,int lei,int huo)
    {
        //     7/12修改
        Sprite s = null;
        if (bing == 3 && lei == 0 && huo == 0)
        {
            //急速冷却
            s =  combiedSkill[0];
        }
        else if (bing == 2 && lei == 1 && huo == 0)
        {
            //幽灵漫步
            s =  combiedSkill[2];
        }
        else if (bing == 2 && huo == 1 && lei == 0)
        {
            //冰墙
            s =  combiedSkill[1];
        }
        else if (lei == 2 && bing == 1 && huo == 0)
        {
            //吹风
            s =  combiedSkill[7];
        }
        else if (lei == 2 && bing == 0 && huo == 1)
        {
            //灵动迅捷
            s =  combiedSkill[4];
        }
        else if (lei == 1 && bing == 0 && huo == 2)
        {
            //陨石
            s =  combiedSkill[8];
        }
        else if (lei == 0 && bing == 1 && huo == 2)
        {
            //火人
            s =  combiedSkill[6];
        }
        else if (lei == 3 && bing == 0 && huo == 0)
        {
            //磁暴
            s =  combiedSkill[3];
        }
        else if (lei == 0 && bing == 0 && huo == 3)
        {
            //天火
            s =  combiedSkill[5];
        }
        else if (lei == 1 && bing == 1 && huo == 1)
        {
            //b刀
            s =  combiedSkill[9];
        }else if (lei + bing+huo < 3) //不能唤醒技能的组合
        {
            s = combiedSkill[10];
        }
        return s;
    }

     public float SkillRange(Sprite skill)
    {
        string name = skill.name;
        float range = 0;
        switch (name)
        {
            case "jslq":
                range = 12;
                break;
            case "bingqiang":
                range = 0;
                break;
            case "ylmb":
                range = 0;
                break;
            case "cibao":
                range = 10.8f;
                break;
            case "ldxj":
                range = 7.8f;
                break;
            case "tianhuo":
                range = 0;
                break;
            case "huoren":
                range = 0;
                break;
            case "chuifeng":
                range = 24;
                break;
            case "yunshi":
                range = 11;
                break;
            case "chaoshengbo":
                range = 10.8f;
                break;
        }
        return range;
    }
}
