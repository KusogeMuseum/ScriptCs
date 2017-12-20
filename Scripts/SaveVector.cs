using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveVector : MonoBehaviour {
	static public void SaveToVector(Vector3 V,string s)
    {
		PlayerPrefs.SetFloat (s, V.x);
		PlayerPrefs.SetFloat (s, V.y);
		PlayerPrefs.SetFloat (s, V.z);
    }
}
