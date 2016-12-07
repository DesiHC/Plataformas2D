using UnityEngine;
using System.Collections;

public class Carrito : MonoBehaviour {
	private WheelJoint2D wj;
	private JointMotor2D jm; 

	// Use this for initialization
	void Start () {
		wj = GetComponent<WheelJoint2D> ();
		jm = wj.motor;
		wj.useMotor = true;
		jm.motorSpeed = -1000f; 
		wj.motor = jm;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Pared") {
			jm.motorSpeed = jm.motorSpeed * -1f;
			wj.motor = jm;

		}
	}

}
