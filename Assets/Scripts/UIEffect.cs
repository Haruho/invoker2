using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 用来处理UI的特效
/// </summary>
public class UIEffect : MonoBehaviour {
    public List<Image> uiBox;
	// Use this for initialization
	void Start () {
        for (int i = 0;i<uiBox.Count;i++)
        {
            uiBox[i].gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            Show();
        }
        Hide();
    }
    void Show()
    {
        if (Input.GetKeyDown(CustomInput.instance.keys[0]))
        {
            uiBox[0].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(CustomInput.instance.keys[1]))
        {
            uiBox[1].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(CustomInput.instance.keys[2]))
        {
            uiBox[2].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(CustomInput.instance.keys[3]))
        {
            uiBox[3].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(CustomInput.instance.keys[4]))
        {
            uiBox[4].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(CustomInput.instance.keys[5]))
        {
            uiBox[5].gameObject.SetActive(true);
        }
    }
    void Hide()
    {
        if (Input.GetKeyUp(CustomInput.instance.keys[0]))
        {
            uiBox[0].gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(CustomInput.instance.keys[1]))
        {
            uiBox[1].gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(CustomInput.instance.keys[2]))
        {
            uiBox[2].gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(CustomInput.instance.keys[3]))
        {
            uiBox[3].gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(CustomInput.instance.keys[4]))
        {
            uiBox[4].gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(CustomInput.instance.keys[5]))
        {
            uiBox[5].gameObject.SetActive(false);
        }
    }
}
