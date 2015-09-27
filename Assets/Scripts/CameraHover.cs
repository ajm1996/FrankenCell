using UnityEngine;
using System.Collections;

public class CameraHover : MonoBehaviour {

	public float height;
	GameObject playerCell;

	void Start () {
		playerCell = GameObject.Find ("PlayerCell");
	}

	void Update () {
		transform.position = new Vector3 (playerCell.transform.position.x, height, playerCell.transform.position.z);
	}
}
