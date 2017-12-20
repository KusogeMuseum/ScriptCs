using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class nameV : MonoBehaviour {
	public InputField inp;
	public GameObject G;
	// Use this for initialization
	void Start () {
		inp = G.GetComponent<InputField> ();
	}
	
	// Update is called once per frame
	public void V(){
		if (inp.text == "" || inp.text == null) {
			PlayerPrefs.SetString ("Hname", "NoName");
		}
		SceneManager.LoadScene ("menu");
	}
}
