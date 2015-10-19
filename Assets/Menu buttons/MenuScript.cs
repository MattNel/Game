using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public GameObject menuM;
	public GameObject OptionsM;
	private bool menu = false;
	private bool opt = false;
	public AudioSource pauseSound;
	// Use this for initialization
	void Start () {
		OptionsM.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	

	
	public void Options(){
		//paused = false;
		menuM.SetActive (false);
		OptionsM.SetActive (true);
	}
	
	public void Exit(){
		//paused = false;
		Application.Quit ();
	}
	
	public void Back(){
		menuM.SetActive (true);
		OptionsM.SetActive (false);
	}
}
