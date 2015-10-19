using UnityEngine;
using System.Collections;

public class SpawnBird : MonoBehaviour {
	public GameObject bird;
	// Use this for initialization
	void Start () {
		Instantiate (bird, this.gameObject.transform.position, this.gameObject.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		InvokeRepeating ("SpawnsBird", 20f, 10f);
	}

	void SpawnsBird()
	{
		Instantiate (bird, this.gameObject.transform.position, this.gameObject.transform.rotation);
		CancelInvoke ();
	}
}
