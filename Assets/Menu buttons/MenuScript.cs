using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public GameObject menuM;
	public GameObject OptionsM;
	public GameObject levelM;
	//private bool menu = false;
	//private bool opt = false;
	public AudioSource pauseSound;
	private CanvasGroup mem;
	private CanvasGroup Opt;
	private CanvasGroup lvl;
	// Use this for initialization
	void Start () {
		//OptionsM.SetActive (false);
		//levelM.SetActive (false);
		//menuM.SetActive (true);
		mem = menuM.GetComponent<CanvasGroup> ();
		Opt = OptionsM.GetComponent<CanvasGroup> ();
		lvl = levelM.GetComponent<CanvasGroup> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	public void NewGame(){
		//paused = false;

		//levelM.SetActive (true);
		while (mem.alpha>0) {
			mem.alpha -= Time.deltaTime ;
			mem.interactable = false;
			mem.blocksRaycasts = false;
		}
		while (lvl.alpha<1) {
			lvl.alpha += Time.deltaTime ;

		}
		lvl.interactable = true;
		lvl.blocksRaycasts = true;
		//menuM.SetActive (false);

	}

	public void lvlBack(){
		//paused = false;
		//menuM.SetActive (true);
		while (lvl.alpha>0) {
			lvl.alpha -= Time.deltaTime / 5;
			lvl.interactable = false;
			lvl.blocksRaycasts = false;
		}
		while (mem.alpha<1) {
			mem.alpha += Time.deltaTime * 5;
		}
		mem.interactable = true;
		mem.blocksRaycasts = true;
		//levelM.SetActive (false);
	}
	
	public void Options(){
		//paused = false;

		//OptionsM.SetActive (true);

		while (mem.alpha>0) {
			mem.alpha -= Time.deltaTime / 2f;
			mem.interactable = false;
			mem.blocksRaycasts = false;
		}
		while (Opt.alpha<1) {
			Opt.alpha += Time.deltaTime * 2f;
		}
		Opt.interactable = true;
		Opt.blocksRaycasts = true;
		//menuM.SetActive (false);

	}
	
	public void Exit(){
		//paused = false;
		Application.Quit ();
	}
	
	public void Back(){
		//menuM.SetActive (true);
		while (Opt.alpha>0) {
			Opt.alpha -= Time.deltaTime / 5;
			Opt.interactable = false;
			Opt.blocksRaycasts = false;
		}
		while (mem.alpha<1) {
			mem.alpha += Time.deltaTime * 5;
		}
		mem.interactable = true;
		mem.blocksRaycasts = true;
		//OptionsM.SetActive (false);
	}


}
