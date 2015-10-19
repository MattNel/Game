using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {

	public Texture2D FadeOutTexture;
	public float fadeSpeed = 0.0f;

	private int drawDepth = -1000;
	private float alpha = 1.0f;
	private int fadeOut = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
