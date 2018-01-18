using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag1 : MonoBehaviour {
		
	public Transform player;

	void OnMouseDrag () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePos.x = mousePos.x > 2.7f ? 2.7f : mousePos.x;
		mousePos.x = mousePos.x < -2.7f ? -2.7f : mousePos.x;
		mousePos.y = mousePos.y > 3.6f ? 3.6f : mousePos.y;
		mousePos.y = mousePos.y < -4.9f ? -4.9f : mousePos.y;
		player.position = new Vector2 (mousePos.x, mousePos.y);
	}

}
