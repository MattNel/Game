﻿using UnityEngine;
using System.Collections;

public class test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public AudioSource test;
    public void OnMouseOver()
    {
        test.Play();
        print("hello world");
    }
}
