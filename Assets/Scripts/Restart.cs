using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	public bool RestartDown;
	private Scene scene;
	// Use this for initialization
	void Start () {
		scene = SceneManager.GetActiveScene ();
	}

	// Update is called once per frame
	void Update () {
		if(RestartDown == true)
		{
			SceneManager.LoadScene (scene.name);
			RestartDown = false;
		}
	}
	public void SettingButton(bool buttonDown) {
		RestartDown = buttonDown;
	}
}