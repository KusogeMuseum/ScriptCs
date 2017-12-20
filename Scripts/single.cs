using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class single : MonoBehaviour {
	public GameObject Ins;
	private GameObject Serth;
	// Use this for initialization
	void Start () {
		Serth = GameObject.FindGameObjectWithTag ("replay");
		if (Serth == null) {
			Instantiate (Ins);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
