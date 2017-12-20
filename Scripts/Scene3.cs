using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Sc()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene("menu");
    }
}
