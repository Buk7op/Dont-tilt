using System.Collections;
using UnityEngine;

public class CreateMoney : MonoBehaviour {

	public GameObject money;

	void Start() {
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn () {
		while(true) {
			Instantiate (money, new Vector2(Random.Range (-2.7f, 2.7f), 5.4f), Quaternion.identity);
			yield return new WaitForSeconds (Random.Range (1f, 3f));
		}

	}
}
