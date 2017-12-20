using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoername : MonoBehaviour {
	private InputField fi;
	private string Name;
	// Use this for initialization
	void Start () {
		fi = gameObject.GetComponent<InputField> ();
	}
	
	// Update is called once per frame
	public void Chenge(){
		Name = fi.text;
		PlayerPrefs.SetString ("Hname", Name);
	}

}
