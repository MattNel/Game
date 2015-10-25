﻿using UnityEngine;
using System.Collections;

public class loosingCondition : MonoBehaviour {

	public int health;
	//float barUnit = 199f;
	public GameObject thePlayer;
	public RectTransform bar;
	public AudioSource damageSound;
	public Animator anim;

	void Start () {
		if(health == 0)
		{
			health = 5;
		}
		anim = thePlayer.GetComponent<Animator>();
		//barUnit = 199;
	}
	
	// Update is called once per frame
	void Update () {
		if(health<0)
		{
			anim.SetBool("Dead",true);
			//thePlayer.SetActive(false);
			//Application.LoadLevel("level3");
		}
	}



	public void damage()
	{
		health--;
		//bar.sizeDelta = new Vector2 ((barUnit -= 39.8f),27);
		//damageSound.Play ();
	}
}
