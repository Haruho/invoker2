
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 用来处理技能的冷却时间
/// </summary>
public class ColdDown : MonoBehaviour {
    public Image coldDown;
    public Text countDown;
    public static ColdDown instance;

    public static bool isInColdDown;
    private float coldTime = 2;
    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
        isInColdDown = false;

        coldDown.gameObject.SetActive(false);
        countDown.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //0.02s执行一次
        //if (Time.time <=coldTime &&  !isInColdDown)
        //{
        //    IntoColdDown();
        //}

        if (isInColdDown)
        {
            IntoColdDown();
        }

    }
    /// <summary>
    /// 进入技能冷却
    /// </summary>
    void IntoColdDown()
    {
        //技能冷却期间组合技能禁用
        SkillSet.isCanCombine = false;
        coldDown.gameObject.SetActive(true);
        countDown.gameObject.SetActive(true);
        //print(Time.time);
        coldDown.fillAmount -= 0.01f;
        coldTime -= 0.02f;
        countDown.text = coldTime.ToString("F1");
        if (coldTime <= 0)
        {
            isInColdDown = false;
            //冷却完毕可以组合技能
            SkillSet.isCanCombine = true;
            coldDown.fillAmount = 1;
            coldTime = 2;
            isInColdDown = false;
            coldDown.gameObject.SetActive(false);
            countDown.gameObject.SetActive(false);
        }
    }
}
