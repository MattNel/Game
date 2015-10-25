using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject player;
	public GameObject pauseM;
	public GameObject gameOver;
	 CanvasGroup gO;
	 CanvasGroup lvlC;
	public GameObject lvlCom;
	private loosingCondition lc;
	private bool paused = false;
	public AudioSource pauseSound;
	 exit winCon;
	public bool dead = false;
	// Use this for initialization
	void Start () {
		winCon = (exit)GameObject.Find ("EXIT").GetComponent (typeof(exit));
		lc =(loosingCondition) GameObject.Find("observer").GetComponent(typeof(loosingCondition));
		pauseM.SetActive (false);
		gO= gameOver.GetComponent<CanvasGroup> ();
		gO.alpha = 0;
		gO.interactable = false;
		gO.blocksRaycasts = false;
		lvlC= lvlCom.GetComponent<CanvasGroup> ();
		lvlC.alpha = 0;
		lvlC.interactable = false;
		lvlC.blocksRaycasts = false;
	}
	
	// Update is called once per frame
	void Update () {
		/*************Pause Menu**************/
		if (Input.GetButtonDown ("pause")) {
			paused = !paused;
		}
		
		if (paused) {
			pauseM.SetActive (true);
			Time.timeScale = 0;
			player.SetActive(false);
			pauseSound.Play ();
		} else {
			player.SetActive(true);
			pauseM.SetActive (false);
			Time.timeScale = 1;

		}
		/********************************/

		/************GameOver***********/

		if (lc.health <= 0) {
			dead = true;
		}
		if (dead) {
			//while(gO.alpha <1)
			//{
			gO.alpha +=  Time.deltaTime/1.3f ;
			
			//Play death sound here
		}
		if (gO.alpha >= 1) {
			gO.blocksRaycasts = true;
			gO.interactable = true;
			Time.timeScale = 0;
		}
		/******************************/

		/*******Level Completed*****/
		if (winCon.getWin()) {
			lvlC.alpha +=  Time.deltaTime ;
			//Play win sound here
		}
		if (lvlC.alpha >= 1) {
			lvlC.blocksRaycasts = true;
			lvlC.interactable = true;
			Time.timeScale = 0;
		}
		/*************************/

	}
	public void next()
	{
		int i = Application.loadedLevel;
		Application.LoadLevel (i + 1);
	}

	public void Retry(){
		Application.LoadLevel (Application.loadedLevel);
	}
	public void Resume(){
		paused = false;
	}
	
	public void Options(){
		//paused = false;
	}
	
	public void Exit(){
		//paused = false;
		Application.LoadLevel ("MainMenu");
	}
}
