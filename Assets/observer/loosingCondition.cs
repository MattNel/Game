﻿using UnityEngine;
using System.Collections;

public class loosingCondition : MonoBehaviour {

	public int health;
	float barUnit = 199f;
	public GameObject thePlayer;
	public RectTransform bar;

    private GameObject sounds;
    private tut3Sound tut3sound;

        void Start () {
        sounds = GameObject.FindGameObjectWithTag("SoundManager");
        tut3sound = sounds.GetComponent<tut3Sound>();

        if (health == 0)
		{
			health = 5;
		}
		barUnit = 199;
	}
	
	// Update is called once per frame
	void Update () {
		if(health<0)
		{
			thePlayer.SetActive(false);
			//Application.LoadLevel("level3");
		}
	}



	public void damage()
	{
		health--;
		bar.sizeDelta = new Vector2 ((barUnit -= 39.8f),27);
		//damageSound.Play ();
	}
}
