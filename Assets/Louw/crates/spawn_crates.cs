using UnityEngine;
using System.Collections;

public class spawn_crates : MonoBehaviour {

	private double timeToSpawn = 0;
	private double spawn = 0;

	public Transform crate;

	void Awake () {
		timeToSpawn = Random.Range(0.1f,0.6f);
		spawn = Random.Range(1f,10f);
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > spawn)
		{
			Instantiate (crate, this.transform.position,  this.transform.rotation);
			spawn = Time.time + 1 / timeToSpawn;
		}
	}
}
