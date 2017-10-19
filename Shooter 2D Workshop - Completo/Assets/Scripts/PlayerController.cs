using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rb;
	public float velocidade;

	public Transform arma;  

	public GameObject Tiro1_Prefab;

	public AudioClip somTiro;
	public AudioSource AudioPlayer;

	public int vidas = 10;

	public int score;

	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (horizontal * velocidade, 0);

		if (Input.GetKeyDown (KeyCode.Space)) {
			Atirar ();
		}

	}

	void Atirar(){
		GameObject tiro = Instantiate (Tiro1_Prefab);
		tiro.transform.position = arma.position;
		AudioPlayer.PlayOneShot (somTiro);
	}

}
