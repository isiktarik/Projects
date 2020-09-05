using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class yonlendirme : MonoBehaviour {
public float hiz,ZiplamaGucu;
	public bool yerdemi,CiftZiplama,android,sol,sag,pause;
	Rigidbody2D agirlik;
	Animator anim;
	public int can, maxcan,coin,star;
	public Text toplamCoin, toplamStar;
	public AudioClip[] sesler;
	public GameObject[] Canlar;




	// Use this for initialization


	void Start () {
		anim = GetComponent<Animator> ();
		agirlik=GetComponent<Rigidbody2D>();
		can = 2;
		CanSistemi ();
		pause = pause;

	
}

	// Update is called once per frame
	void Update () {
		toplamCoin.text = "" + coin;
		toplamStar.text = "" + star;
		if (Input.GetKeyDown(KeyCode.R)) {
			Application.LoadLevel (Application.loadedLevel);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {

			agirlik.velocity = new Vector3(0, 10, 0);
			ziplab ();

			}

		}
		

	void FixedUpdate()
	{float h = Input.GetAxis ("Horizontal");
		anim.SetFloat ("hiz", Mathf.Abs (h));
		anim.SetBool ("yerde", yerdemi);
		if (android) {
		if (sol) {
				h = -1;
				transform.localScale= new Vector3 (-2,2,2);
				transform.Translate (h*hiz*Time.deltaTime,0,0);
			}
		if (sag) {
				h = 1;
				transform.localScale= new Vector3 (2,2,2);
				transform.Translate (h*hiz*Time.deltaTime,0,0);
			}
		if (!sol && !sag) {
				h = 0;

			}





			
		} else {	
			


			agirlik.AddForce (Vector3.right * h * hiz);
			anim.SetFloat ("hiz", Mathf.Abs (h));
			anim.SetBool ("yerde", yerdemi);
		}
		}

	void CanSistemi()
	{
		for (int i = 0; i < maxcan; i++) {

			Canlar [i].SetActive (false);
		}
		for (int i = 0; i < can; i++) {

			Canlar [i].SetActive (true);
		}
		if (can==0) {
			
			olme ();
		}
	

		}
	void olme(){


		Application.LoadLevel (Application.loadedLevel);
	}
	void OnCollisionEnter2D(Collision2D nesne)
	{
		if (nesne.gameObject.tag=="tuzak") {
			tuzakses ();
			can -= 1;
			CanSistemi ();
			GetComponent<SpriteRenderer> ().color = Color.yellow;
			Invoke ("duzelt",0.1f);
			agirlik.AddForce(Vector2.up * ZiplamaGucu);
			}
		if (nesne.gameObject.tag == "finish") {

			for (int i=0; i <= LevelKontrol.ToplamLevelDegeri; i ++) 
			{

				if (Application.loadedLevelName == "Level"+i.ToString ()) 
				{										

					if(	LevelKontrol.suankiLevel > i ) 
					{
						Application.LoadLevel ("levelcomplete");

					}
					else 
					{

						PlayerPrefs.SetInt("Level",i+1); 
						Application.LoadLevel ("levelcomplete");

					}
				}
			}


		}
	
	}
	void OnTriggerEnter2D(Collider2D nesne)
	{
		
		if (nesne.gameObject.tag=="star") {
			starses ();
			star += 20;

			Destroy (nesne.gameObject);

		}
		if (nesne.gameObject.tag == "coin") {
			coinses ();
			coin += 10;
			Destroy (nesne.gameObject);
		}


		if (nesne.gameObject.tag=="bosluk") {

			CanSistemi ();
			olme ();
			}
	

		}


	void duzelt()
	{
		GetComponent<SpriteRenderer> ().color = Color.white;
	}
	public void ziplab()
	{
		ziplamases ();
		if (yerdemi) {
			agirlik.AddForce(Vector2.up* ZiplamaGucu);
			CiftZiplama = true;
		}
		else {
			if (CiftZiplama) {
				CiftZiplama = false;
				agirlik.AddForce(Vector2.up * ZiplamaGucu);
			}


		}
	}
	public void tuzakses()
	{
		
			GetComponent<AudioSource> ().PlayOneShot (sesler [3]);

	}
	public void starses()
	{
		
			GetComponent<AudioSource>().PlayOneShot(sesler[0]);	
		

	}
	public void coinses()
	{ 
		
			GetComponent<AudioSource> ().PlayOneShot (sesler [2]);

	}
	public void ziplamases()
	{
		
			GetComponent<AudioSource> ().PlayOneShot (sesler [1]);

	}




}
