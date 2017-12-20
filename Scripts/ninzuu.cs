using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ninzuu : MonoBehaviour {
	private Text t;
	// Use this for initialization
	void Start () {
		t = gameObject.GetComponent<Text> ();
		if (PlayerPrefs.HasKey ("iine")) {
			t.text = PlayerPrefs.GetInt ("iine").ToString()+"人";
		} else {
			t.text = 0.ToString ()+"人";
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		t.text = PlayerPrefs.GetInt ("iine").ToString ()+"人";
	}
}
