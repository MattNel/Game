using UnityEngine;
using System.Collections;

public class MainMenuSoundManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    GameObject newGameBtn = GameObject.FindGameObjectWithTag("NewGame");
    GameObject OptionsBtn = GameObject.FindGameObjectWithTag("Options");
    GameObject ExitBtn = GameObject.FindGameObjectWithTag("EndGame");


    public AudioSource EnterSound;
    public AudioSource HoverSound;

    public void PlaySoundHover()
    {
        HoverSound.Play();
    }

    public void PlaySoundEnter()
    {
        EnterSound.Play();
    }
}
