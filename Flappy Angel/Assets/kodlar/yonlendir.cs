using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class yonlendir : MonoBehaviour {
	public int skor, HighScore,sonskor;
	public Text score,Toplamskor,bitisskor,bitisyuksekskor;
	public bool sol,sag,android,pause,gameover;

	// Use this for initialization
	void Start () {
		
		HighScore = PlayerPrefs.GetInt ("Highscore", HighScore);
		Toplamskor.text = HighScore.ToString();

		
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "" + skor;



	}
	void FixedUpdate()
	{float h=Input.GetAxis ("Horizontal");
		
		if (android) {
			if (sol) {
				h = -1;

				transform.Translate(new Vector2(h*Time.deltaTime*5, 0));
			}
			if (sag) {
				h= -1;

				transform.Translate(new Vector2(-h*Time.deltaTime*5, 0));
			}
			if (!sol && !sag) {
				h = 0;

			} 
	}
	}
	 void OnCollisionEnter2D(Collision2D carpisma)
{

			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}





	void OnTriggerEnter2D(Collider2D nesne)
	{

		if (nesne.gameObject.tag == "engel") {
			
			
			skor += 1;
			if (skor > HighScore) {
				HighScore = skor;
				Toplamskor.text = "" + skor;

				PlayerPrefs.SetInt ("Highscore", HighScore);
				PlayerPrefs.SetInt ("Score", skor);

			}

		}

	}
	}

