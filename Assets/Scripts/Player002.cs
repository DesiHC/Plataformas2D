using UnityEngine;
using System.Collections;

public class Player002 : MonoBehaviour {
	private Animator animator;
	private Rigidbody2D rb;

	void start (){
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("right"))
			
	
	}
}
