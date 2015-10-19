using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject pauseM;
	private bool paused = false;
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
		} else {
			pauseM.SetActive (false);
			Time.timeScale = 1;
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
