using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour {
	public GameObject menuler;
	public string anamenum;
	yonlendirme yr;



	public void anamenu()
	{
		Application.LoadLevel (anamenum);
	}

}
