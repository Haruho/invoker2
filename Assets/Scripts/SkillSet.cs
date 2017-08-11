#region 模块信息
// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             SkillSet.cs
// 作者(Author):                  #zch#
// 创建时间(CreateTime):           #2017/7/10#
// 修改者列表(modifier):            zch
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

    public List<Sprite> skills;
    //技能没进入冷却是不是可以F
    public static bool isCanCombine;
    public static SkillSet instance;
    //当前组合的技能是不是技能栏中的第二个
    private bool isSameToSecondSkill;
    //当前组合的技能是不是技能栏中的第一个
    private bool isSameToFirstSkill;
    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
        //    temp = combine_1.sprite;
        isCanCombine = true;
    }
	
	// Update is called once per frame
	void Update () {
        //input
        if (Input.anyKeyDown)
        {
            GetInput();
            //当前所携带的元素
            ChangeElements();

            ChangeSkillImage();
        }
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
        //元素组合   并且执行技能冷却   其中交换技能位置不需要冷却 和  组合相同的英雄不触发冷却
        if (Input.GetKeyDown(CustomInput.instance.keys[3]) && isCanCombine)
        {
            CombineElements();
        }
        //技能键位  默认是Q
        if (Input.GetKeyDown(CustomInput.instance.keys[4]))
        {
            ReleaseSkill.isReadyToRelease = true;
            ReleaseSkill.combineSkillIndex = 0;
            ReleaseSkill.skillRange = Global.instance.SkillRange(skills[1]);
        }
        if (Input.GetKeyDown(CustomInput.instance.keys[5]))
        {
            ReleaseSkill.isReadyToRelease = true;
            ReleaseSkill.combineSkillIndex = 1;
            ReleaseSkill.skillRange = Global.instance.SkillRange(skills[0]);
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
    /// <summary>
    /// 和上面的函数一样，通过数组来替换图标
    /// </summary>
    void ChangeSkillImage()
    {
        if (skills.Count!= 0)
        {
            combine_1.sprite = skills[skills.Count - 1];
        }
        if (skills.Count>1)
        {
            combine_2.sprite = skills[skills.Count - 2];
        }
        if (skills.Count > 2)
        {
            skills.RemoveAt(0);
        }
    }
    void CombineElements() {
        int bing = 0;
        int lei = 0;
        int huo = 0;
        //=============对携带元素进行计数==================
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
        }
        //添加技能并且避免两个位置技能相同
        //这个函数会在调换两个技能的位置的时候失效
        //if (!skills.Contains(Global.instance.getSkillSprite(bing, lei, huo)))
        //{
        //    skills.Add(Global.instance.getSkillSprite(bing, lei, huo));
        //}

        //添加第一个技能
        if (skills.Count == 0)
        {
            skills.Add(Global.instance.getSkillSprite(bing, lei, huo));
            ColdDown.isInColdDown = true;
        }
        //组合技能，不是当前组合调出的技能就行
        if (!skills[skills.Count-1].Equals((Global.instance.getSkillSprite(bing, lei, huo))))
        {
            skills.Add(Global.instance.getSkillSprite(bing, lei, huo));
        }
        //这里解决了交换技能位置并不出发冷却的功能
        if (skills.Count > 1)
        {
            if (skills[0].Equals((Global.instance.getSkillSprite(bing, lei, huo))))
            {
                ColdDown.isInColdDown = false;
            }
            else
            {
                ColdDown.isInColdDown = true;
            }
        }
    }
}
