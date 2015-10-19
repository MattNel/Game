using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public GameObject following;
	
	// Update is called once per frame
	void Update () {
		transform.position = following.transform.position;

		transform.rotation = following.transform.localRotation;
	}
}
