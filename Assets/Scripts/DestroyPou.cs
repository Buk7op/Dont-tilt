
using UnityEngine;

public class DestroyPou : MonoBehaviour {


	void Update () {

		if (transform.position.y < -5.4f)
			Destroy (gameObject);
	}
}
