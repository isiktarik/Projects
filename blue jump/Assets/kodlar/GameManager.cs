using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Transform AktifSetler, PasifSetler,hero;
	private Transform RandomSet;




	// Use this for initialization
	void Start () {
		StartCoroutine (CheckForVisibility());



	 
	}
	
	// Update is called once per frame
	void Update () {
		hero = GameObject.FindGameObjectWithTag ("hero").transform;

	}

	void Recycle()
	{
		RandomSet=PasifSetler.GetChild(Random.Range(0,PasifSetler.childCount));
		RandomSet.parent = AktifSetler;
		RandomSet.SetAsLastSibling ();
		RandomSet.localPosition = AktifSetler.GetChild (AktifSetler.childCount - 2).localPosition + new Vector3 (80,0,0);

		RandomSet = AktifSetler.GetChild (0);
		RandomSet.parent = PasifSetler;
		RandomSet.localPosition = PasifSetler.GetChild (0).localPosition;


	}
	IEnumerator CheckForVisibility()
	{
		while(true)
		{
			yield return new WaitForEndOfFrame ();
			if (AktifSetler.GetChild(0).GetComponent<SpriteRenderer>().isVisible==false) {

				Recycle ();
			}
		}
	}


	}
	

