using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReleaseSkill : MonoBehaviour {
    public static bool isReadyToRelease;
    public static ReleaseSkill instance;
    public Transform player;

    public static int combineSkillIndex;
    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start () {
        isReadyToRelease = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (isReadyToRelease)
        {
            ReadyToReleaseSkill(SkillSet.instance.skills[combineSkillIndex] , );
        }
	}
    //按下技能键代表准备释放技能
    public void ReadyToReleaseSkill(Sprite skill , float range)
    {
        if (GameObject.FindGameObjectWithTag("Range"))
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            go.transform.tag = "Range";
            go.transform.position = player.position;
            go.transform.localScale = new Vector3(skillRange, 0.03f, skillRange);
        }
        if (Input.GetMouseButtonDown(0))
        {
            print("asdasdasd");
        }
    }
}
