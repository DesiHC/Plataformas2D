using UnityEngine;
using System.Collections;

public class MonedaBro : MonoBehaviour {
	private Rigidbody2D rb;
	GameObject txt_moneda;
	control_monedas ctrl_moneda; 

	// Use this for initialization
	void Start () {
		Destroy (gameObject,10);
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2(Random.Range (-0.02f,0.02f), 0.02f));
		txt_moneda = GameObject.Find ("texto_moneda");
		ctrl_moneda = txt_moneda.GetComponent<control_monedas> ();

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			ctrl_moneda.suma_monedas (1);
			Destroy (gameObject);
			Random.Range (0.02f, 0.02F);

		}
	}
}
