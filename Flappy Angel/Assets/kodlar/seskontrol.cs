using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskontrol : MonoBehaviour {

	// Use this for initialization
	AudioSource ses;
	bool seskapali;

	void Start () {

		ses = GetComponent<AudioSource> ();
		PlayerPrefs.GetInt ("ses");


	}

	// Update is called once per frame
	void Update () {

	}

	public void SesAcik()
	{ 

		AudioListener.volume = 1;
		seskapali = false;
		PlayerPrefs.SetInt("ses", 1);







	}
	public void SesKapali()
	{
		AudioListener.volume = 0;
		seskapali = true;
		PlayerPrefs.SetInt("ses", 0);
	}
}
