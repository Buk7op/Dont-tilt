using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class CameraShake : MonoBehaviour {

	Vector3 cameraInitialPosition;
	public float shakeMagnetude = 0.02f;
	public GameObject text;

	void Start(){
		cameraInitialPosition = text.transform.position;

	}
	void Update(){
		
		float cameraShakingOffsetX = Random.value * shakeMagnetude * 2  - shakeMagnetude;
		float cameraShakingOffsetY = Random.value * shakeMagnetude * 2 - shakeMagnetude;
		Vector3 cameraIntermadiatePosition = text.transform.position;
		cameraIntermadiatePosition.x += cameraShakingOffsetX;
		cameraIntermadiatePosition.y += cameraShakingOffsetY;
		text.transform.position = cameraIntermadiatePosition;
		if (Mathf.Abs(cameraInitialPosition.x - text.transform.position.x) > 0.01 && Mathf.Abs(cameraInitialPosition.y - text.transform.position.y) > 0.01 )
			text.transform.position = cameraInitialPosition;
	
	}




}
