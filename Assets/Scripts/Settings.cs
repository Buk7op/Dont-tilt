using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {
	public bool SettingDown;
	public GameObject SettingsMenu, mainMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(SettingDown == true)
		{
			mainMenu.SetActive (false);
			SettingsMenu.SetActive (true);
		}
		else if(SettingDown == false)
		{
			
			SettingsMenu.SetActive (false);
		}
	}
	public void SettingButton(bool buttonDown) {
		SettingDown = buttonDown;
	}
}
