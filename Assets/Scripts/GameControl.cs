using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	private Vector3 punto_inicio;
	public GameObject player;
	public bool esta_vivo = true;

	void Start(){
		punto_inicio = player.transform.position;
		Debug.Log ("X" + player.transform.position.x);
	}

	public void respawn(){
		player.transform.position = punto_inicio;

	}
	public void checkpoint(Vector3 nuevo_punto){
		punto_inicio = nuevo_punto;
	}
}
