using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	private GameControl gcs;

	// Use this for initialization
	void Start () {
		gcs = GameObject.Find ("GameControl").GetComponent<GameControl> ();
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			gcs.checkpoint (transform.position);
		}
	}
}