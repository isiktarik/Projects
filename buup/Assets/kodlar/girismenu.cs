using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girismenu : MonoBehaviour {
	public string levelsahne;
	public string settings;
	public GameObject menu;

	public	void basla()
	{PlayerPrefs.Save ();
		Application.LoadLevel (levelsahne);
	}
		public void quit()
	{
		PlayerPrefs.Save ();
		Application.Quit ();

	}
}
