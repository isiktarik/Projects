using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class kureandroid : MonoBehaviour {

	yonlendirme yr;
	public GameObject[] Butonlar;
	// Use this for initialization
	void Start () {
		yr = GetComponent<yonlendirme> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void sol()
	{
		yr.sol = true;
	}
	public void sag()
	{
		yr.sag = true;
	}
	public void solup()
	{
		yr.sol = false;
	}
	public void sagup()
	{
		yr.sag = false;
	}
	public void ziplama()
	{
		
			if (yr.yerdemi) {
				yr.ziplab ();
			}
			}





}
