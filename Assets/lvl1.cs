using UnityEngine;
using System.Collections;

public class lvl1 : MonoBehaviour {

    private GameObject sounds;
    private tut3Sound tut3sound;




    void Start()
    {
        sounds = GameObject.FindGameObjectWithTag("SoundManager");
        tut3sound = sounds.GetComponent<tut3Sound>();

        tut3sound.playlvl1();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
