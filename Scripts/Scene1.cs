using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void Scene()
    {
        SceneManager.LoadScene("Shoot");
    }
}
