using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anamenu : MonoBehaviour {
	public Text Yuksekskor;
	void Start()
	{
		Yuksekskor.text=PlayerPrefs.GetInt ("Highscore").ToString();
	}
	public void Baslat()
	{
		Application.LoadLevel ("MainScene");
	}
	public void Cikis()
	{
		Application.Quit ();
	}
}
