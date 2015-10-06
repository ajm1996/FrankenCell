using UnityEngine;
using System.Collections;

public class SpiroAI : MonoBehaviour {

	public float speed;
	public float aggroDitance;
	public float size;

	Vector3 randTargetPosition;
	float i;
	float j;
	float radius = 20;

	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("PlayerCell");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position == randTargetPosition || randTargetPosition == new Vector3(0, 0, 0)) {
			bool flag;
			do{
				flag = false;
				i = Random.value * (radius - 1) * (Random.value > 0.5? 1 : -1);
				j = Random.value * (radius - 1) * (Random.value > 0.5? 1 : -1);
				randTargetPosition = new Vector3 (i, 0.77f, j);
				if(Vector3.Distance(randTargetPosition, new Vector3(0, 0.77f, 0)) > (radius - 1)) {
					flag = true;
				}
			} while (flag);
		}

		if (Vector3.Distance (transform.position, player.transform.position) < aggroDitance) {
			if (size * 0.95 > player.GetComponent<PlayerScript>().playerSize) {
				transform.position = Vector3.MoveTowards (transform.position,
				                                          player.transform.position, speed / 10 * Time.deltaTime);
				transform.LookAt(player.transform.position);
			} else {
				transform.position = Vector3.MoveTowards (transform.position, randTargetPosition, speed / 10 * Time.deltaTime);
				transform.LookAt(randTargetPosition);
			}

		} else {
			transform.position = Vector3.MoveTowards (transform.position, randTargetPosition, speed / 10 * Time.deltaTime);
			transform.LookAt(randTargetPosition);
		}
	}
}
