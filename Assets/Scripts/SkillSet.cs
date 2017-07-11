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
    //当前携带的元素
    public List<Image> currentElements;
    public List<Image> skill;
    //显示当前携带的元素
    public Image current1;
    public Image current2;
    public Image current3;

    public Image combine_1;
    public Image combine_2;
    //代表三个元素
    public Image qust;
    public Image wex;
    public Image exort;

    private Image tempa;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        //input
        if (Input.anyKeyDown)
        {
            GetInput();
        }
        //当前所携带的元素
        ChangeElements();


        ////还没有组合技能
        //if (combine_1.sprite.name == "null" && combine_2.sprite.name == null)
        //{
        //    tempa = combine_1;
        //}
        ////只有一个组合技能
        //else if(combine_1.sprite.name != null && combine_2.sprite.name ==null)
        //{
        //    tempa = combine_2;
        //}else if (combine_1.sprite.name != null&&combine_2.sprite.name != null)
        //{
        //    com
        //}
    }
    void GetInput()
    {
        //根据输入更新当前携带元素
        if (Input.GetKeyDown(CustomInput.instance.keys[0]))
        {
            currentElements.Add(qust);
        }
        if (Input.GetKeyDown(CustomInput.instance.keys[1]))
        {
            currentElements.Add(wex);
        }
        if (Input.GetKeyDown(CustomInput.instance.keys[2]))
        {
            currentElements.Add(exort);
        }
        //元素组合
        if (Input.GetKeyDown(CustomInput.instance.keys[3]))
        {
            CombineElements();
        }
    }
    void ChangeElements()
    {
        //使用List来制作当前携带元素
        if (currentElements.Count != 0)
        {
            current1.sprite = currentElements[currentElements.Count - 1].sprite;
        }
        if (currentElements.Count > 1)
        {
            current2.sprite = currentElements[currentElements.Count - 2].sprite;
        }
        if (currentElements.Count > 2)
        {
            current3.sprite = currentElements[currentElements.Count - 3].sprite;
            currentElements.RemoveRange(0, currentElements.Count - 3);
        }
    }

    void CombineElements() {
        int bing = 0;
        int lei = 0;
        int huo = 0;
        for (int i =0;i<currentElements.Count;i++)
        {
            if (currentElements[i].sprite.name =="qust")
            {
                bing++;
            }
            if (currentElements[i].sprite.name == "wex")
            {
                lei++;
            }
            if (currentElements[i].sprite.name == "exort")
            {
                huo++;
            }
            if (bing == 3)
            {
                //急速冷却
                combine_1.sprite = Global.instance.SkillConfirm("jslq");
            }else if (bing == 2&& lei ==1 && huo ==0)
            {
                //幽灵漫步
                combine_1.sprite = Global.instance.SkillConfirm("ylmb");
            }else if (bing ==2 && huo == 1&& lei ==0)
            {
                //冰墙
                combine_1.sprite = Global.instance.SkillConfirm("bingqiang");
            }else if (lei ==2&&bing ==1&&huo ==0)
            {
                //吹风
                combine_1.sprite = Global.instance.SkillConfirm("chuifeng");
            }
            else if (lei == 2 && bing == 0 && huo == 1)
            {
                //灵动迅捷
                combine_1.sprite = Global.instance.SkillConfirm("ldxj");
            }
            else if (lei == 1 && bing == 0 && huo == 2)
            {
                //陨石
                combine_1.sprite = Global.instance.SkillConfirm("yunshi");
            }
            else if (lei == 0 && bing == 1 && huo == 2)
            {
                //火人
                combine_1.sprite = Global.instance.SkillConfirm("huoren");
            }
            else if (lei == 3 && bing == 0 && huo == 0)
            {
                //磁暴
                combine_1.sprite = Global.instance.SkillConfirm("cibao");
            }
            else if (lei == 0 && bing == 0 && huo == 3)
            {
                //天火
                combine_1.sprite = Global.instance.SkillConfirm("tianhuo");
            }
            else if (lei == 1 && bing == 1 && huo == 1)
            {
                //b刀
                combine_1.sprite = Global.instance.SkillConfirm("chaoshengbo");
            }
        }
    }
}
