using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanage : MonoBehaviour {
	static public float time=0;
	// Use this for initialization
	void Start () {
		time = 0;
		if (SceneManager.GetActiveScene ().name == "Shoot") {
			Enemy.speed = 0.1f;
		}
		if (SceneManager.GetActiveScene ().name == "menu") {
			RepEnemy.speed = 0.1f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "Shoot") {
			time += Time.deltaTime;
			if (Time.timeScale == 1) {
				if (time < 4.9f) {
					Enemy.speed = 0.1f;
				}
				if (9.9f>=time&&time>5.0f) {
					Enemy.speed = 0.2f;
            
				}
				if (time > 10f && time < 14.9f) {
					Enemy.speed = 0.3f;
				}
				if (time > 15f && time < 19.9f) {
					Enemy.speed = 0.4f;
				}
				if (time > 20f && time < 24.9f) {
					Enemy.speed = 0.5f;

				}
				if (time > 25f && time < 29.9f) {
					Enemy.speed = 0.6f;
				}
				if (time > 30f) {
					Enemy.speed = 0.7f;
				}

			} else {
				if (Time.timeScale == 0) {
					Enemy.speed = 0;
				}
			}
		}
		if (SceneManager.GetActiveScene ().name == "menu") {
			
			time += Time.deltaTime;

			if (time < 4.9f) {
				RepEnemy.speed = 0.1f;
			}
			if (9.9f>=time&&time>5.0f) {
				RepEnemy.speed = 0.2f;

			}
			if (time > 10f && time < 14.9f) {
				RepEnemy.speed = 0.3f;
			}
			if (time > 15f && time < 19.9f) {
				RepEnemy.speed = 0.4f;
			}
			if (time > 20f && time < 24.9f) {
				RepEnemy.speed = 0.5f;

			}
			if (time > 25f && time < 29.9f) {
				RepEnemy.speed = 0.6f;
			}
			if (time > 30f) {
				RepEnemy.speed = 0.7f;
			
			}
		}
	}
}
