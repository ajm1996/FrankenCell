using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float playerSize;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void onCollisionEnter(Collider c) {
		print ("success");
	}

	void onTriggerEnter(Collider c) {
		print ("success2");
	}

}
