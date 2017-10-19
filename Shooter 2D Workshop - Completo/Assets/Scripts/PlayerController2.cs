using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

	public Rigidbody2D rb;
	public float velocidade;
	public GameObject tiro;
	public Transform arma;

	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (horizontal * velocidade ,rb.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space)) {
			Atirar ();
		}

	}

	void Atirar(){
		GameObject tiroInstancia = Instantiate (tiro);
		tiroInstancia.transform.position = arma.position;
	}
}
