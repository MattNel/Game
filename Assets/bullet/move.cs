using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float movement_speed;
	bool direction = true;



	 //Update is called once per frame
	void Update () {
		if (direction) {

			transform.Translate (Vector3.left * Time.deltaTime * movement_speed);
		} else {
			transform.Translate (Vector3.right * Time.deltaTime * movement_speed);
		}
		Destroy (this.gameObject, 5);	
	}

	public void changeMovement(){
		direction = !direction;
	}

}
