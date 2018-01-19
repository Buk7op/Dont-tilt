using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableEnable : MonoBehaviour {
	public Button button;
	public Sprite enabled, disabled;
	public bool status;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();
	}

	void Update (){
		if (status == true)
			button.image.overrideSprite = disabled;
		else
			button.image.overrideSprite = enabled;
		
	}

public void SettingButton(bool buttonDown) {
		if (status == false)
			status = buttonDown;
		else
			status = !buttonDown;
}
}
