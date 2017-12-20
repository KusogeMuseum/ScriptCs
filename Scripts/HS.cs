using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HS : MonoBehaviour {
    private Text te;
	// Use this for initialization
	void Start () {
        te = gameObject.GetComponent<Text>();
        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score",0);
            te.text ="NoName:"+0.ToString();
        }
        else
        {
			te.text = PlayerPrefs.GetString("Hname")+":"+PlayerPrefs.GetInt ("Score").ToString ();

        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
