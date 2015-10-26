using UnityEngine;
using System.Collections;

public class rotateDiamond : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0,90f *Time.deltaTime,0);

	
	}


}
