using UnityEngine;
using System.Collections;

public class tut3Sound : MainMenuSoundManager {

	// Use this for initialization
	void Start () {
        EnterSound.volume = (InterfaceSound / 10f);
        HoverSound.volume = (InterfaceSound / 10f);

        shootSound.volume = (EffectsSound / 10f);
        swapSound.volume = (EffectsSound / 10f);
        grenadeSound.volume = (EffectsSound / 10f);
        grenadeFallSound.volume = (EffectsSound / 10f);
        runSound.volume = (EffectsSound / 10f);
        damageSound.volume = (EffectsSound / 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("a") || Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
            playRun();

        if (Input.GetKeyUp("a")|| Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
            playRunStop();



    }
}
