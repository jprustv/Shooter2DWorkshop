using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoController : MonoBehaviour {

	public Rigidbody2D rb;
	public float velocidade;

	public Transform arma;
	public GameObject tiro;

	void Start(){
		Atirar ();
	}

	void Update () {
		rb.velocity = new Vector2 (0, velocidade * -1);

	}

	void Atirar(){
		GameObject tiroInstancia = Instantiate (tiro);
		tiroInstancia.transform.position = arma.position;
	}

}

