using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController2 : MonoBehaviour {

	public float velocidade;

	void Update () {
		transform.position = new Vector3 (transform.position.x, 
			transform.position.y + velocidade, transform.position.z);
	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}

}
