using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class record : MonoBehaviour {
	static public List<Vector3> recp;
	private GameObject ob;
	// Use this for initialization
	void Start () {
		recp=new List<Vector3>();
		ob = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (ob != null) {
			recp.Add (ob.transform.position);
		}
	}
}
