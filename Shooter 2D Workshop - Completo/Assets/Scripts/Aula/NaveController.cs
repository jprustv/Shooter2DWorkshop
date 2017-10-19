using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveController : MonoBehaviour {

	public Rigidbody2D rb;
	public float velocidade;

	public Transform arma;
	public GameObject tiro;

	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (horizontal * velocidade, 0);
		if (Input.GetKeyDown (KeyCode.Space)) {
			Atirar ();
		}

	}

	void Atirar(){
		GameObject tiroInstancia = Instantiate (tiro);
		tiroInstancia.transform.position = arma.position;
	}

}
