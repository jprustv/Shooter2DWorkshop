using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour {

	public PlayerController player;
	public Text vidas;
	public Text tempo;

	public Text pontuacao;
	public Text record;

	public float tempoTotal;

	void Update () {

		Debug.Log (PlayerPrefs.GetInt ("score"));

		vidas.text = "Vidas: " + player.vidas.ToString();

		tempo.text = (tempoTotal - (Mathf.Round(Time.timeSinceLevelLoad))).ToString ();

		pontuacao.text = ApplicationModel.score.ToString ();
		record.text = PlayerPrefs.GetInt ("Record").ToString();

		if (tempo.text == "0") { // GANHOU
			if (PlayerPrefs.GetInt("score") < ApplicationModel.score){
				PlayerPrefs.SetInt ("score", ApplicationModel.score);
			}
			ApplicationModel.ganhou = true;
			SceneManager.LoadScene ("PosFase");
		}
	
		if (player.vidas == 0) { // PERDEU
			ApplicationModel.ganhou = false;
			SceneManager.LoadScene ("PosFase");
		}

	}
}
