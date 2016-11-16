using UnityEngine;
using System.Collections;
[RequireComponent (typeof(BoxCollider2D))] //Con esto añades un boxcollider a cualquier objeto que tenga este script

public class EnlazarPlayer : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.transform.parent = transform;
		}
	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.transform.parent = null;
		}
	}
}
