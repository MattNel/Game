using UnityEngine;
using System.Collections;

public class MainMenuSoundManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public AudioSource EnterSound;
    public AudioSource HoverSound;

    public void PlaySoundHover()
    {
       // Debug.Log("hello world");
        HoverSound.Play();
    }

    public void PlaySoundEnter()
    {
        //Debug.Log("hello world");
        EnterSound.Play();
    }
}
