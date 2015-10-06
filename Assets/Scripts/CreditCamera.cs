using UnityEngine;
using System.Collections;

public class CreditCamera : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > -30) {
			transform.Translate (0, -speed * Time.deltaTime, 0);
		}
        if (transform.position.y > -93 && transform.position.y < -30) {
            transform.Translate(0, -speed * 3 * Time.deltaTime, 0);
        }
		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel("Main");
		}
	}
}
