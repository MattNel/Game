using UnityEngine;
using System.Collections;

public class lvl4 : MonoBehaviour {
    private GameObject sounds;
    private tut3Sound tut3sound;




    void Start()
    {
        sounds = GameObject.FindGameObjectWithTag("SoundManager");
        tut3sound = sounds.GetComponent<tut3Sound>();

        tut3sound.playlvl4();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
