using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PosFase : MonoBehaviour {
	public TextMesh msgWinLose;
	public Button btnTryAgain;
	public Button btnNextLevel;
	// Use this for initialization
	void Start () {
		if (ApplicationModel.ganhou) {
			msgWinLose.text = "Parabéns!\nVocê ganhou.";
			btnTryAgain.gameObject.SetActive (false);
		} else {
			msgWinLose.text = "Que pena!\nVocê perdeu.";
			btnNextLevel.gameObject.SetActive (false);
		}
	}

	public void Restart(){
		SceneManager.LoadScene ("Fase1");
	}

	public void Next(){
		SceneManager.LoadScene ("Entrada");
	}

}
