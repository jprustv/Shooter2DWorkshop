using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D rb;
	public float velocidade;
	public GameObject tiroPrefab;
	public Transform arma;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxisRaw ("Horizontal");

		rb.velocity = new Vector2 (velocidade * horizontal, 0);

		if (Input.GetKeyDown (KeyCode.Space)) {
			Atirar ();
		}

	}

	void Atirar(){
		GameObject tiro = Instantiate (tiroPrefab);	
		tiro.transform.position = arma.position;
	}

}
