using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemintrigger : MonoBehaviour {

	yonlendirme yr,zp;
	// Use this for initialization
	void Start () {

		yr = transform.root.gameObject.GetComponent<yonlendirme> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D()
	{
		yr.yerdemi = true;


	}
	void OnTriggerStay2D()
	{
		yr.yerdemi = true;



	}
	void OnTriggerExit2D()
	{
		yr.yerdemi = false;

	}
}
