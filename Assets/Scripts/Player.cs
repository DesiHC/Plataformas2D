using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class Player : MonoBehaviour {
	public float velocidad = 5f;
	public float salto = 10f;
	public float power = 1f;
	public bool tocando_suelo = false;
	public AudioClip sonido_salto;	
	public AudioClip sonido_morir;	
	public AudioClip sonido_moneda;
	private AudioSource audio;
	private Animator animator;
	private Rigidbody2D rb;
	private GameControl gcs;
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		audio = GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody2D> ();
		gcs = GameObject.Find ("GameControl").GetComponent<GameControl> ();
	}
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("velocidad_animator", Mathf.Abs(rb.velocity.x));
		if (Input.GetKey("right"))
		{
			rb.velocity = new Vector2(velocidad*power,rb.velocity.y);
			transform.localScale = new Vector3(1, 1, 1);
		
		}
		if (Input.GetKey("left"))
		{
			rb.velocity = new Vector2(-velocidad*power,rb.velocity.y);
			transform.localScale = new Vector3(-1, 1, 1);
		}

		if(Input.GetKeyDown(KeyCode.Space) && tocando_suelo){
			animator.SetBool ("saltando", true);
			rb.AddForce (new Vector2(0,salto));
			audio.PlayOneShot (sonido_salto);
		}
	}

	void OnTriggerStay2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocando_suelo = true;
		}
	}

	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocando_suelo = false;

		}
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocando_suelo = true;
			animator.SetBool ("saltando", false);		
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "muerte") {
			audio.PlayOneShot (sonido_morir);
			Invoke ("muerte", 1);
		}
		if (col.gameObject.tag == "Moneda")
			audio.PlayOneShot(sonido_morir);

	}


	void muerte (){
		gcs.respawn ();
	}
}



