using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject player;
	public GameObject pauseM;
	private bool paused = false;
	public AudioSource pauseSound;
	// Use this for initialization
	void Start () {
		pauseM.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("pause")) {
			paused = !paused;
		}
		
		if (paused) {
			pauseM.SetActive (true);
			Time.timeScale = 0;
			player.SetActive(false);
		} else {
			player.SetActive(true);
			pauseM.SetActive (false);
			Time.timeScale = 1;
			pauseSound.Play ();
		}
	}
	
	public void Resume(){
		paused = false;
	}
	
	public void Options(){
		//paused = false;
	}
	
	public void Exit(){
		//paused = false;
		Application.Quit ();
	}
}
