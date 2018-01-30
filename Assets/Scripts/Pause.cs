using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Pause : MonoBehaviour {

    public float timing;
    public bool isPaused;
    public GameObject  mmButton, mainMenu, menu, delaytxt, shade, taptostarttxt, score, Highscore, money, pauseButton;
	public Text delayPause; 
	public bool dispDelay, gogo;
	float time, difference;
	void Start () {
		taptostarttxt.SetActive (true);
		score.SetActive (false);
		Highscore.SetActive (false);
		money.SetActive (false);
		pauseButton.SetActive (false);
	}
	
	void Update () {

		Time.timeScale = timing;
		if (dispDelay == true) {
			shade.SetActive (false);
			menu.SetActive (false);
			difference = 4 - (Time.realtimeSinceStartup - time);
			delaytxt.SetActive (true);
			delayPause.text = "" + (int)difference;
		} 
		else if (dispDelay == false)
		{
			delaytxt.SetActive (false);
		}

		if(isPaused == true)
        {
			shade.SetActive (true);
			menu.SetActive (true);
            timing = 0;
        }
		else if(isPaused == false && difference < 1.05 && gogo == true)
        {
			mmButton.SetActive (false);
			shade.SetActive (false);
            timing = 1;
			menu.SetActive (false);
			dispDelay = false;
        }
	}

	public void PauseButton(bool statePause) {
		if (statePause == false) {
			time = Time.realtimeSinceStartup;
			isPaused = false;
			dispDelay = true;
			} 
		else
		{
		isPaused = true;
		dispDelay = false;
		}
	}

	public void TapTo(bool tap) {
			gogo = tap;
			taptostarttxt.SetActive (false);
			score.SetActive (true);
			Highscore.SetActive (true);
			money.SetActive (true);
			pauseButton.SetActive (true);
	}

	public void MainMenu (bool tap) {
		mainMenu.SetActive (tap);

	}

	public void Exit (bool tap) {
		if (tap == true) {
			Application.Quit ();
			Debug.Log ("quit");
		}
	}
}
