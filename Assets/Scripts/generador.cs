using UnityEngine;
using System.Collections;

public class generador : MonoBehaviour {
	public GameObject[] monedas;
	private Transform pos_salida;
	private GameObject moneda_nueva;
	private int numero_moneda = 0;
	Animator anim;

	void Start(){
		pos_salida = transform.Find ("Posicion_salida").transform;
		//Con esto buscamos un objeto dentro del objeto del script. Es decir, estamos bucando un hijo del objeto. Para buscar un objeto en general es GameObject.Find
	}


	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			numero_moneda = Random.Range (0, monedas.Length-1);
			moneda_nueva = (GameObject) Instantiate (monedas[numero_moneda], 
				pos_salida.position, 
				transform.rotation);
			
		}
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && moneda_nueva == null) {
			moneda_nueva = (GameObject) Instantiate (monedas[0], 
				transform.position, 
				transform.rotation);
		}

	}
		

	
	}
	
	