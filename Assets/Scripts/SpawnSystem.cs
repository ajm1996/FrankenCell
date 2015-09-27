using UnityEngine;
using System.Collections;

public class SpawnSystem : MonoBehaviour {

	public float minSpawnDistanceFromPlayer;
	public GameObject SuperCell;
	public GameObject Spiro;

	int count;

	void Start () {
		while (count < 15) {

			float i = Random.value * 20;
			float j = Random.value * 20;
			Vector3 position = new Vector3(i, 1, j);
			while(Vector3.Distance(position, transform.position) < minSpawnDistanceFromPlayer
			      && Vector3.Distance(position, GameObject.Find("PetriDish").transform.position) < 20) {
				i = Random.value * 20;
				j = Random.value * 20;
				position = new Vector3(i, 1, j);
			}

			switch(Random.Range(0, 1)) {
			case 0:
				Instantiate(SuperCell, position, new Quaternion(0, 0, 0, 0));
				break;
			case 1:
				Instantiate(Spiro, position, new Quaternion(0, 0, 0, 0));
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
