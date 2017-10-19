using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController2 : MonoBehaviour {

	private float totalTime = 0;
	public float intervalo = 2;

	public GameObject prefabInimigo;
	
	// Update is called once per frame
	void Update () {
		totalTime += Time.deltaTime;
		if (totalTime >= intervalo) {
			GameObject novoInimigo = Instantiate (prefabInimigo);
			novoInimigo.transform.position = new Vector3(Random.Range(-3.80f, 3.60f), 
				novoInimigo.transform.position.y, novoInimigo.transform.position.z);
			totalTime = 0;
		}

	}
}
