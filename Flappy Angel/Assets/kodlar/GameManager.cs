using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Transform AktifSetler, PasifSetler;
	public float hiz;
	private Transform RandomSet;



	// Use this for initialization
	void Start () {
		StartCoroutine (CheckForVisibility());
		StartCoroutine(Move());
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void Recycle()
	{
		RandomSet=PasifSetler.GetChild(Random.Range(0,PasifSetler.childCount));
		RandomSet.parent = AktifSetler;
		RandomSet.SetAsLastSibling ();
		RandomSet.localPosition = AktifSetler.GetChild (AktifSetler.childCount - 2).localPosition + new Vector3 (0,8,0);

		RandomSet = AktifSetler.GetChild (0);
		RandomSet.parent = PasifSetler;
		RandomSet.localPosition = PasifSetler.GetChild (0).localPosition;


	}
	IEnumerator CheckForVisibility()
	{
		while(true)
		{
			yield return new WaitForEndOfFrame ();
			if (AktifSetler.GetChild(0).GetChild(1).GetComponent<SpriteRenderer>().isVisible==false) {

				Recycle ();
			}
		}
	}
	IEnumerator Move()
	{
		while (true) {
			hiz = hiz + Time.deltaTime/4;
			Camera.main.transform.Translate (Vector2.up * hiz*Time.deltaTime);
			yield return null;
		}
	}

	}

