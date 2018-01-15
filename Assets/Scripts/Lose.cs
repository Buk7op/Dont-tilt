using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour {
	public GameObject pointControl, playerObj;
	public int Score;
	public int HighScore;
	public int Multipier;
	private float timer;
	public Text txtScore, txtHighScore;
	GameObject[] pous;
	void Update () {
		txtScore.text ="" + Score;
		txtHighScore.text = "" + HighScore;
		pous = GameObject.FindGameObjectsWithTag ("pou");
		Multipier = pous.Length;
		timer += Time.deltaTime;
		if (!(pointControl.transform.position.y > playerObj.transform.position.y)) {
			if (timer > 1 / Multipier) {
				Score++;
				timer = 0;
			}
		} 
		else
			Score = 0;
		if (Score > HighScore)
			HighScore = Score;
	}


}
