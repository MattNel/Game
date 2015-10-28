using UnityEngine;
using System.Collections;

public class MM : MonoBehaviour {

    private GameObject sounds;
    private MainMenuSoundManager mainmenusound;




    void Start()
    {
        sounds = GameObject.FindGameObjectWithTag("SoundManager");
        mainmenusound = sounds.GetComponent<MainMenuSoundManager>();

        mainmenusound.playmainMenu();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
