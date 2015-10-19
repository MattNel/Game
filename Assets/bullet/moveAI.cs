using UnityEngine;
using System.Collections;

public class moveAI : MonoBehaviour {

	public float movement_speed;
	public int distance;


	void Start()
	{
		if (distance == 0) {
			distance = 5;

		}
	}
	// Update is called once per frame
	void Update () {
//		if (direction) {
//			
			transform.Translate (Vector3.left * Time.deltaTime * movement_speed);
//		} else {
//			transform.Translate (Vector3.right * Time.deltaTime * movement_speed);
//		}
		
		Destroy (this.gameObject, distance);	
	}
	
//	public void changeMovement(){
//		direction = !direction;
//	}

}
