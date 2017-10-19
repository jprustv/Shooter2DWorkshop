using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

	public float spawnInterval;
	private float timePast = 0;
	public GameObject inimigoPrefab;
	public Transform limiteEsquerda;
	public Transform limiteDireita;

	void Start(){
		GameObject inimigo = Instantiate (inimigoPrefab);
		Vector3 novaPosicao = inimigo.transform.position;
		novaPosicao.x = Random.Range (limiteEsquerda.position.x + 1.5f, 
			limiteDireita.position.x - 1.5f);
		inimigo.transform.position = novaPosicao;
	}

	void FixedUpdate () {
		timePast += Time.deltaTime;
		if (timePast >= spawnInterval) {
			GameObject inimigo = Instantiate (inimigoPrefab);
			Vector3 novaPosicao = inimigo.transform.position;
			novaPosicao.x = Random.Range (limiteEsquerda.position.x + 1.5f, 
				limiteDireita.position.x - 1.5f);
			inimigo.transform.position = novaPosicao;
			timePast = 0;
		}
	}
}
