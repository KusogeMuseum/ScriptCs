using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tenmetu : MonoBehaviour {
	private float time;
	private Text tex;
	// Use this for initialization
	void Start () {
		tex = gameObject.GetComponent<Text> ();
		time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time<=0.3f){
			tex.enabled = true;
		}else{
			tex.enabled=false;
			time=0;
		}
	}
}
