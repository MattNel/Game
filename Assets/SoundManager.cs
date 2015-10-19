using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    public AudioSource PlayerFire;
    public AudioSource PlayerGrenade;
    public AudioSource PlayerSwap;
    public AudioSource PlayerDamage;
    public AudioSource PauseSound;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("pause"))
        {
            //playPause();
        }
    }

    public void PlayPlayerFire()
    {
        PlayerFire.Play();
    }

    public void PlayPlayerGrenade()
    {
        PlayerGrenade.Play();
    }

    public void PlayPlayerSwap()
    {
        PlayerSwap.Play();
    }

    public void PlayPlayerDamage()
    {
        PlayerDamage.Play();
    }

    void playPause()
    {
        PauseSound.Play();
    }
}
