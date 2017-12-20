using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class debug2 : MonoBehaviour {
	public InputField i;
	// Use this for initialization
	void Start () {
		i = gameObject.GetComponent<InputField> ();
	}
	
	// Update is called once per frame
	public void D () {
		if (i.text == "DeleteAllSaveData") {
			PlayerPrefs.DeleteAll ();
		}
	}
}
