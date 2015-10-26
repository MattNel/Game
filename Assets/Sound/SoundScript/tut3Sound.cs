using UnityEngine;
using System.Collections;

public class tut3Sound : MainMenuSoundManager {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("a") || Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
            playRun();

        if (Input.GetKeyUp("a")|| Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
            playRunStop();
    }

    public AudioSource shootSound;
    public AudioSource swapSound;
    public AudioSource grenadeSound;
    public AudioSource grenadeFallSound;
    public AudioSource runSound;
    public AudioSource damageSound;

    public void playShoot()
    {
        shootSound.Play();
    }

    public void playSwap()
    {
        swapSound.Play();
    }

    public void playGrenade()
    {
        grenadeSound.Play();
    }

    public void playGrenadeFall()
    {
        grenadeFallSound.Play();
    }

    public void playGrenadeFallStop()
    {
        grenadeFallSound.Stop();
    }

    public void playRun()
    {
        runSound.Play();
    }

    public void playRunStop()
    {
        runSound.Stop();
    }

    public void playDamage()
    {
        damageSound.Play();
    }
}
