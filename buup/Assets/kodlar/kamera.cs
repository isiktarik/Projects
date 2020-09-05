using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour {
	public Transform kure;
	public float x,y;
	// Use this for initialization
	void Start () {
		kure = GameObject.FindGameObjectWithTag ("top").transform;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (kure.position.x+x,kure.position.y+y,-10);


	}
}
