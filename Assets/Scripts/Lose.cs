using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour {
	public GameObject pointControl, playerObj;
	public int Money, saveMoney, Score, HighScore, Multipier;
	private float timer;
	public Text txtScore, txtHighScore, txtMoney;
	GameObject[] pous;
	void Start() {
		Money = PlayerPrefs.GetInt ("savemoney");
		HighScore = PlayerPrefs.GetInt ("savescore");
	}

	void Update () {

	//----------Счет и сохранение денег------------------
		txtMoney.text = "" + Money;
		PlayerPrefs.SetInt ("savemoney", Money);
	//---------------------------------------------------

		txtScore.text = "" + Score;
		txtHighScore.text = "" + HighScore;
		PlayerPrefs.SetInt ("savescore", HighScore);
		PlayerPrefs.Save ();
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
