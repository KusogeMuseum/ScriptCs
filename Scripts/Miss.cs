using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miss : MonoBehaviour {
    private GameObject Player;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (Player != null)
        {
            Vector3 playerpos = Player.transform.position;
            var direct = (playerpos - transform.position).normalized;
            transform.position = transform.position + (direct * 2.5f*Time.deltaTime);
            transform.rotation = Quaternion.FromToRotation(Vector3.up, direct);
            Destroy(gameObject, 3.25f);
        }
        else
        {
            Destroy(gameObject);
        }
	}
}
