using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class File : MonoBehaviour {
    private List<string> finame=new List<string>();
    public GameObject audi;
    public AudioSource[] audiS;
    private string[] s;
    private AudioClip cli;
    private AudioSource A;
	// Use this for initialization
	void Start () {
        audi = GameObject.FindGameObjectWithTag("MainCamera");
        audiS = audi.GetComponents<AudioSource>();
        A = audiS[0];
        if (!Directory.Exists(Application.dataPath + "/Musics")){
            Directory.CreateDirectory(Application.dataPath + "/Musics");
        }
        else 
        {
            s = Directory.GetFiles(Application.dataPath + "/Musics","*.wav");
            if (s.Length!=0)
            {
                foreach(string d in s)
                {
                    
                        finame.Add(d.ToString());
                        
                    
                }
                StartCoroutine(Stream());
            }
        }
	}
	IEnumerator Stream()
    {
        int i= Random.Range(0, finame.Count);
        A.clip = null;
        string op = finame[i];
      
        using (WWW W = new WWW("file://"+op))
        {

            yield return W;
            
            A.clip = W.GetAudioClip(false,true);
          
            A.Play();

        }

    }
	// Update is called once per frame
	void Update () {
		
	}
}
