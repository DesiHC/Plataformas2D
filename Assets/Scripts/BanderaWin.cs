using UnityEngine;
using System.Collections;

public class BanderaWin : MonoBehaviour {

	public Sprite banderaWin;


	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			GetComponent<SpriteRenderer> ().sprite = banderaWin;
		}
}
}
