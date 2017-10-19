using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2 : MonoBehaviour {

	public Rigidbody2D rb;
	public float velocidade;

	public Transform arma;  

	public GameObject tiro;

	void Start(){
		Atirar ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = new Vector2 (0, velocidade * -1);

	}

	void Atirar(){
		GameObject tiroInstancia = Instantiate (tiro);
		tiroInstancia.transform.position = arma.position;
	}

}
