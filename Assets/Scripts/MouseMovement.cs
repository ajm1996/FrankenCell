using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {

	public float moveSpeed = 10;
	
	void Start () {
	
	}


	void Update () {

		//TODO: smooth acceleration

		/*
		transform.LookAt(new Vector3(transform.position.x + ((Input.mousePosition.x - (Screen.width / 2)) / 1000 * moveSpeed * Time.deltaTime), 
		                             1, transform.position.z + ((Input.mousePosition.x - (Screen.width / 2)) / 1000 * moveSpeed * Time.deltaTime)));

		print (new Vector3 (transform.position.x + ((Input.mousePosition.x - (Screen.width / 2)) / 1000 * moveSpeed * Time.deltaTime), 
		                   1, transform.position.z + ((Input.mousePosition.x - (Screen.width / 2)) / 1000 * moveSpeed * Time.deltaTime)));
		                   */

		/* Vector3 mouseVector = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
		Vector3 mPos = Camera.main.ScreenToWorldPoint(mouseVector);
		
		Quaternion targetRotation = Quaternion.LookRotation (mPos - transform.position);
		targetRotation.x = 0.0f;
		targetRotation.y = 0.0f;
		
		
		float str = Mathf.Min (5 * Time.deltaTime, 1);
		transform.rotation = Quaternion.Lerp (transform.rotation, targetRotation, str);
		*/

		if (Input.GetMouseButton(0)) {
			transform.Translate ((Input.mousePosition.x - (Screen.width / 2)) / 1000 * moveSpeed * Time.deltaTime, 0,
			                     (Input.mousePosition.y - (Screen.height / 2)) / 1000 * moveSpeed * Time.deltaTime);

		}
	}
}
