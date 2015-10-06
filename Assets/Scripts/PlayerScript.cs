using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float growthForEating;
	public float playerSize;

	void OnTriggerEnter(Collider c) {
		if (c.GetComponent<SuperCellAI> () != null) {
			float size = c.GetComponent<SuperCellAI> ().size;
			if(size * 0.95 <= playerSize) {
				Destroy (c.gameObject);
				GetComponent<SpawnSystem>().count--;
				transform.localScale += new Vector3(growthForEating, 0, growthForEating);
				playerSize = (transform.localScale.x) / 20.68418f;
				GameObject.Find("Camera").GetComponent<CameraHover>().height += 0.1f;
			} else {
				playerSize -= (size - playerSize);
				if(playerSize < 1) {
					Application.LoadLevel("Lose");
				}
				transform.localScale = new Vector3(20.68418f * playerSize, 0.4093631f, 20.68418f * playerSize);
				GameObject.Find("Camera").GetComponent<CameraHover>().height -= 0.1f;
			}
		}
		if (c.GetComponent<SpiroAI> () != null) {
			float size = c.GetComponent<SpiroAI> ().size;
			if(size * 0.95 <= playerSize) {
				Destroy (c.gameObject);
				GetComponent<SpawnSystem>().count--;
				transform.localScale += new Vector3(growthForEating, 0, growthForEating);
				playerSize = (transform.localScale.x) / 20.68418f;
				GameObject.Find("Camera").GetComponent<CameraHover>().height += 0.045f;
			} else {
				playerSize -= (size - playerSize);
				if(playerSize < 1) {
					Application.LoadLevel("Lose");
				}
				transform.localScale = new Vector3(20.68418f * playerSize, 0.4093631f, 20.68418f * playerSize);
				GameObject.Find("Camera").GetComponent<CameraHover>().height -= 0.045f;
			}
		}
	}

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel ("Main");
		}
		if (playerSize > 5) {
			Application.LoadLevel("Win");
		}
	}



}
