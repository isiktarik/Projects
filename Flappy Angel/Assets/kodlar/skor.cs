using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour {
	private int yuksekskor;
	public Text Toplamskor;
	yonlendir yr;
	// Use this for initialization
	void Start () {
		yuksekskor = PlayerPrefs.GetInt ("Highscore");
		Toplamskor.text = yuksekskor.ToString ();

	}

	// Update is called once per frame
	void Update () {
		
	}
}
