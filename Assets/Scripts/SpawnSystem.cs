using UnityEngine;
using System.Collections;

public class SpawnSystem : MonoBehaviour {

	public float minSpawnDistanceFromPlayer;
	public int numOfEnemies;
	public float enemySizeRangeFromPlayer;
	public GameObject SuperCell;
	public GameObject Spiro;
	public int count;

	float playerSize;

	void Start () {
		playerSize = GameObject.Find ("PlayerCell").GetComponent<PlayerScript>().playerSize;

		while (count < numOfEnemies) {
			spawn ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (count < numOfEnemies) {
			spawn ();
		}
	}

	void spawn() {
		float i = Random.value * 20 * (Random.value > 0.5? 1 : -1);
		float j = Random.value * 20 * (Random.value > 0.5? 1 : -1);
		Vector3 position = new Vector3(i, 0.77f, j);

		while(Vector3.Distance(position, transform.position) < minSpawnDistanceFromPlayer
		      || Vector3.Distance(position, GameObject.Find("PetriDish").transform.position) > 20) {
			i = Random.value * 20;
			j = Random.value * 20;
			position = new Vector3(i, 0.77f, j);
		}
		
		float enemySize = Random.Range(playerSize - enemySizeRangeFromPlayer, playerSize + enemySizeRangeFromPlayer);
		
		switch(Random.Range(0, 2)) {
		case 0:
			GameObject newSuperCell = (GameObject) Instantiate(SuperCell, position, new Quaternion(0, 0, 0, 0));
			newSuperCell.GetComponent<SuperCellAI>().size = enemySize;
			newSuperCell.transform.localScale = new Vector3(newSuperCell.transform.localScale.x * enemySize, newSuperCell.transform.localScale.y, newSuperCell.transform.localScale.z * enemySize);
			count++;
			break;
		case 1:
			GameObject newSpiro = (GameObject) Instantiate(Spiro, position, new Quaternion(0, 0, 0, 0));
			newSpiro.GetComponent<SpiroAI>().size = enemySize;
			newSpiro.transform.localScale = new Vector3(newSpiro.transform.localScale.x * enemySize, newSpiro.transform.localScale.y, newSpiro.transform.localScale.z * enemySize);
			count++;
			break;
			
		default:
			break;
		}
	}
}
