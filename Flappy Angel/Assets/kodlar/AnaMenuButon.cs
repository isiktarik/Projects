using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaMenuButon : MonoBehaviour {
public void  StartGame()
	{
		
			Application.LoadLevel ("anasahne");
		}
	public void Quit()
	{
		Application.Quit ();
	}
}
