using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour {

	public float velocidade;

	public bool tiroInimigo = false;

	public PlayerController player;

	void Start(){
		player = GameObject.Find ("Player").GetComponent<PlayerController> ();
	}

	void Update () {
		if (!tiroInimigo) {
			transform.position = new Vector3 (transform.position.x, transform.position.y + velocidade, transform.position.z);
		} else {
			
			transform.position = new Vector3 (transform.position.x, transform.position.y - velocidade, transform.position.z);
		}

	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "inimigo" && !tiroInimigo){
			ApplicationModel.score += 20;
			if (ApplicationModel.score > PlayerPrefs.GetInt ("Record")) {
				PlayerPrefs.SetInt ("Record", ApplicationModel.score);
			}
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.collider.tag == "Player" && tiroInimigo) {
			player.vidas--;
			Destroy (this.gameObject);
		}
	}

}
