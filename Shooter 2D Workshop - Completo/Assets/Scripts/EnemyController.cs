using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public Rigidbody2D rb;
	public float velocidade;

	public Transform arma;

	public GameObject Tiro1_Prefab;

	public PlayerController player;

	void Start(){
		Atirar ();

		player = GameObject.Find ("Player").GetComponent<PlayerController> ();

	}

	void FixedUpdate () {
		rb.velocity = new Vector2 (0, velocidade * -1);

	}

	void Atirar(){
		GameObject tiro = Instantiate (Tiro1_Prefab);
		tiro.transform.position = arma.position;
	}

	void OnBecameInvisible(){
		if (player != null) {
			if (transform.position.y < player.transform.position.y) {
				player.vidas--;
				Destroy (this.gameObject);
			}
		}
	}

}
