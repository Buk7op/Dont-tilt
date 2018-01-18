using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;

public class Pause : MonoBehaviour {

    public float timing;
    public bool isPaused;
    public GameObject menu, delaytxt, shade;
	public Text delayPause; 
	public bool dispDelay;
	float time, difference;
	void Start () {
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
		else if(isPaused == false && difference < 1.05)
        {
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
}
