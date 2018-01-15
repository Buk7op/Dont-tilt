using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {
	public int score, record;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (score > record) {
			PlayerPrefs.SetInt ("savescore", score);
			PlayerPrefs.Save ();
		}
		record = PlayerPrefs.GetInt ("savescore");
		
	}
}
