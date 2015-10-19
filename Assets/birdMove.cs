using UnityEngine;
using System.Collections;

public class birdMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Vector2.left * Time.deltaTime * 14f);
	}
}
