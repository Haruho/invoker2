using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReleaseSkill : MonoBehaviour {
    public static float skillRange;
    public static bool isReadyToRelease;
    public static ReleaseSkill instance;
    public GameObject skillRangeObject;
    public Transform player;
    public Material transparent;
    public static int combineSkillIndex;
    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
        isReadyToRelease = false;
        skillRangeObject.transform.localScale = new Vector3(0,0.1f,0);
    }
	
	// Update is called once per frame
	void Update () {
        if (isReadyToRelease)
        {
            ReadyToReleaseSkill(skillRange);
        }
	}
    //按下技能键代表准备释放技能
    public void ReadyToReleaseSkill(float range)
    {
        skillRangeObject.transform.localScale = new Vector3(range, 0.1f, range);
        if (Input.GetMouseButtonDown(1))
        {
            skillRangeObject.transform.localScale = new Vector3(0, 0.1f, 0);
            isReadyToRelease = false;
        }
    }
}
