using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {

	public float moveSpeed = 5;
	
	void Start () {
	
	}


	void Update () {
		if (Input.GetMouseButton(0)) {
			transform.Translate ((Input.mousePosition.x - Screen.width / 2) / 50000 * moveSpeed, 0, (Input.mousePosition.y - Screen.height / 2) / 50000 * moveSpeed);
		}

	}
}
