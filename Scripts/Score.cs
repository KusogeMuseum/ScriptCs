using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    public int Scre;
    private int Hscre=0;
    private Text t;
    public GameObject t1;
    private Text t2;
    static public bool Hb;
	private string Hname;
	// Use this for initialization
	void Start () {
        Hb = false;
            Scre = 0;
        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score", Scre);
        }
        else
        {
            Hscre = PlayerPrefs.GetInt("Score");
        }
		if (PlayerPrefs.HasKey ("Hname")) {
			Hname = PlayerPrefs.GetString ("Hname");
		} else {
			PlayerPrefs.SetString ("Hname", "");
			Hname = PlayerPrefs.GetString ("Hname");
		}
           
        
        t = gameObject.GetComponent<Text>();
        t2 = t1.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Hscre == 0 || Hscre <= Scre)
        {
            PlayerPrefs.SetInt("Score", Scre);
            Hscre = PlayerPrefs.GetInt("Score");
            Hb = true;
        }
        t.text = "Score:"+Scre.ToString();
			t2.text = "HighScore:" + Hscre.ToString();
        
	}
}
