using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public AudioSource test2;
    public void OnMouseOver()
    {
        test2.Play();
        print("hello world");
    }
}
