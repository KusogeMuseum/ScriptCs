using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause2 : MonoBehaviour {
    public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	public void Sc()
    {

        Time.timeScale = 1;
        obj.SetActive(false);
    }
}
