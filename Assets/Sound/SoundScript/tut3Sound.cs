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

        Enemy1Sound.volume = (EffectsSound / 10f);
        Enemy2Sound.volume = (EffectsSound / 10f);
        CrateSound.volume = (EffectsSound / 10f);
        JumpSound.volume = (EffectsSound / 10f);
        JumpLandSound.volume = (EffectsSound / 10f);

        mainMenu.volume = (BackgroundSound / 10f);
        lvl1.volume = (BackgroundSound / 10f);
        lvl2.volume = (BackgroundSound / 10f);
        lvl3.volume = (BackgroundSound / 10f);
        lvl4.volume = (BackgroundSound / 10f);
    }

    // Update is called once per frame

    void Update()
    {
        
        if (Input.GetKeyDown("a") || Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
            playRun();

        if (Input.GetKeyUp("a")|| Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
            playRunStop();

        if(Input.GetKeyDown("space"))
        {
            playJump();
        }
        if(Input.GetKeyDown("p"))
        {
            playPause();
        }
        
       /* if (pp.landed == true)
            playJumpLand();*/
    }
}
