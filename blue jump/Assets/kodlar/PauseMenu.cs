using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {
	
	public string mainMenu;
	public bool isPaused;
	public GameObject pauseMenuCanvas;
	public GameObject SkorCanvas;
	Yonlendirme yr;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;


		} else {
				
			pauseMenuCanvas.SetActive (false);


		}
			}

	public void Pausebuton()
	{
		isPaused = !isPaused;
		SkorCanvas.SetActive (false);
		}
		public void Resume()
	{
		Time.timeScale = 1f;
		isPaused = false;
		SkorCanvas.SetActive (true);
		}
	public void Restart()
	{
		Application.LoadLevel (Application.loadedLevel);
		isPaused = false;

	}
			public void Quit()
	{
		Application.LoadLevel (mainMenu);
	}
	}


	



