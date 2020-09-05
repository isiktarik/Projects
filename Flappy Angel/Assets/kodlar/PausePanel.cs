using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour {
	public string mainMenu;
	public bool isPaused;
	public GameObject pauseMenuCanvas;
	yonlendir yr;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;


		} else {

			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;

		}
		
	}
	public void Pausebuton()
	{
		isPaused = !isPaused;
	}
	public void Resume()
	{
		isPaused = false;
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
