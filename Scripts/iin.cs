using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class iin : MonoBehaviour {
    static private int iine;
    static private int iine2;
    public GameObject TEl;
    private Text t;
	// Use this for initialization
	void Start () {
        t = TEl.GetComponent<Text>();
        if (!PlayerPrefs.HasKey("iine"))
        {
            iine = 0;
            PlayerPrefs.SetInt("iine", iine);
            iine2 = PlayerPrefs.GetInt("iine");
        }
        else
        {
            iine2 = PlayerPrefs.GetInt("iine");
        }
        

    }
    public void iine4()
    {
        
        iine2 += 1;
        PlayerPrefs.SetInt("iine",iine2);
        iine2 = PlayerPrefs.GetInt("iine");
        t.text ="あなたは"+iine2+ "人目です。ありがとうございました！";
        gameObject.SetActive(false);
    }
	
	
}
