using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ins2 : MonoBehaviour {
	private GameObject o;
	public GameObject o1;
	// Use this for initialization
	void Start () {
		o = GameObject.FindGameObjectWithTag ("Debug");
		if (o==null) {
			Instantiate (o1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
