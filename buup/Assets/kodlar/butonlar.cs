using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butonlar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (gameObject.name == "1") {

			GetComponent<Button> ().interactable = true;
		} else {

			if (PlayerPrefs.GetInt (gameObject.name) == 1) {

				GetComponent<Button> ().interactable = true;
			} else {
				GetComponent<Button> ().interactable = false;
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
