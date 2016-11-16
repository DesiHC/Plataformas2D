using UnityEngine;
using System.Collections;

public class MovimientoRecto : MonoBehaviour {
	public GameObject plataforma;
	public Transform inicio;
	public Transform fin;
	public float velocidad = 10f;
	private Vector3 destino; //variable?

	// Use this for initialization
	void Start () {
		destino = fin.position; //Fin es un transform, tienes que especificar si quieres position, scale o rotation
	}
	
	// Update is called once per frame
	void Update () { //Update se ejecuta una vez cada frame
		plataforma.transform.position = 
			Vector3.MoveTowards (plataforma.transform.position,
				destino,
				velocidad * Time.deltaTime); //MoveTowards mueve algo entre dos puntos. en este caso "plataforma" se mueve desde su posición hasta destino.

		if (plataforma.transform.position == fin.position) {
			destino = inicio.position;
		}

		if (plataforma.transform.position == inicio.position) {
			destino = fin.position;
		}
	}
}
