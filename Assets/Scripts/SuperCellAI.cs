using UnityEngine;
using System.Collections;

public class SuperCellAI : MonoBehaviour {

	public float speed;
	public float aggroDitance;

	Vector3 randTargetPosition;
	float i;
	float j;
	float radius;

	GameObject player;

	// Use this for initialization
	void Start () {
		radius = 20;
		player = GameObject.Find ("PlayerCell");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position == randTargetPosition || randTargetPosition == new Vector3(0, 0, 0)) {
			bool flag = true;
			while(flag) {
				i = Random.value * (radius - 1) * (Random.value > 0.5? 1 : -1);
				j = Random.value * (radius - 1) * (Random.value > 0.5? 1 : -1);
				randTargetPosition = new Vector3 (i, 1, j);
				if(Vector3.Distance(randTargetPosition, transform.position) < (radius - 1)) {
					flag = false;
				}
			}
		}

		if (Vector3.Distance (transform.position, player.transform.position) < aggroDitance) {
			if (transform.localScale.x > player.transform.localScale.x) {
				transform.position = Vector3.MoveTowards (transform.position,
				                                          player.transform.position, speed / 10 * Time.deltaTime);
				transform.LookAt(player.transform.position);
			} else {
				//randTargetPosition = (transform.position - player.transform.position).normalize
				//	* (20 - Math.abs(transform.position - GameObject.Find ("PetriDish").transform.position));
			}

		} else {
			transform.position = Vector3.MoveTowards (transform.position, randTargetPosition, speed / 10 * Time.deltaTime);
			transform.LookAt(randTargetPosition);
		}
	}
}
