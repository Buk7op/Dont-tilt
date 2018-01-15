
using UnityEngine;

public class DestroyMoney : MonoBehaviour {
	public static bool contact = false;
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "money")
			contact = true;
	}

	void Update () {

		if (transform.position.y < -5.4f || contact == true)
			Destroy (gameObject);
		    contact = false;
	}
}
