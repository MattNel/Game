using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	public GameObject door;
	public GameObject switchB;
	public bool button = false;

	void OnTriggerEnter2D(Collider2D other){

		button = true;
	}

	void OnTriggerExit2D(Collider2D other){
		
		button = false;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(button)
		{
			Debug.Log("in");
			if(door.transform.position.y < 125)
			{
			door.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
			}
			if(switchB.transform.position.y > -130)
			{
			switchB.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
			}
	}
		if (door.transform.position.y > 104.7 && !button) {
			door.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
		}
		if (switchB.transform.position.y < -128.02 && !button) {
			switchB.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		}

}
}