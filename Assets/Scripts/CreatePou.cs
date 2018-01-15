using System.Collections;
using UnityEngine;

public class CreatePou : MonoBehaviour {

	public GameObject pou;

	void Start() {
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn () {
		while(true) {
			Instantiate (pou, new Vector2(Random.Range (-2.7f, 2.7f), 5.4f), Quaternion.identity);
				yield return new WaitForSeconds (0.8f);
		}
	}
}
