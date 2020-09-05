using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Yonlendirme : MonoBehaviour {

	// Use this for initialization
	public int skor, HighScore,ZiplamaGucu,birkez;
	public float hiz;
	public Text score,bitisskor,bitisyuksekskor;
	public bool pause,gameover,yerdemi,CiftZiplama;
	Rigidbody2D agirlik;
	Animator anim;
	public GameObject SkorCanvas;
	public GameObject dokun;
	public GameObject skorgizle;
	public AudioClip[] sesler;


	// Use this for initialization
	void Start () {
		HighScore = PlayerPrefs.GetInt ("Highscore", HighScore);

		bitisyuksekskor.text = HighScore.ToString();
		anim = GetComponent<Animator> ();
		agirlik=GetComponent<Rigidbody2D>();
		Time.timeScale = 0;
		dokun.SetActive (true);

	
	}

	// Update is called once per frame
	void Update () {
		hiz = hiz + Time.deltaTime / 10;
		score.text = "" + skor;
		if (Input.GetMouseButtonDown(0)) {
			dokun.SetActive (false);
			Time.timeScale = 1;
			ziplab ();
		}
;
		float h = Input.GetAxis ("Horizontal");


		anim.SetBool ("yerde",yerdemi);
		anim.SetFloat ("hiz",hiz);
		transform.Translate (Vector2.right* hiz * Time.deltaTime);

		}

		


			





	void OnCollisionEnter2D(Collision2D carpisma)
	{
		if (carpisma.gameObject.tag=="canavar") {
			Time.timeScale = 0f;
			hiz=0;
			hiz--;
			SkorSonuc ();
		}

		//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}





	void OnTriggerEnter2D(Collider2D nesne)
	{

		if (nesne.gameObject.tag == "gecis") {
			Debug.Log ("Geçti");



			skor += 20;
			if (skor > HighScore) {
				HighScore = skor;
				bitisyuksekskor.text = "" + skor;
				PlayerPrefs.SetInt ("Highscore", HighScore);
					}

		}


	}
	void SkorSonuc()
	{
		SkorCanvas.SetActive (true);
		bitisskor.text = score.text;
		bitisyuksekskor.text = PlayerPrefs.GetInt ("Highscore").ToString ();
		skorgizle.SetActive (false);

	}
	public void ziplab()
	{
		
		if (yerdemi) {
			
			GetComponent<AudioSource> ().PlayOneShot (sesler[0]);
			agirlik.AddForce(Vector2.up*ZiplamaGucu);

			CiftZiplama = true;
			birkez = birkez;
		}
		else {
			if (CiftZiplama) {
				CiftZiplama = false;


			}


		}
	}


		


}
