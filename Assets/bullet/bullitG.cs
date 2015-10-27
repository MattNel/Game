using UnityEngine;
using System.Collections;

public class bullitG : MonoBehaviour {

	//float movement_speed = 70;
	public GameObject explosion;
	bool direction = true;

	void Start ()
	{
		Vector2 dir =  Camera.main.ScreenToWorldPoint (Input.mousePosition) - gameObject.transform.position;
		dir.Normalize();
		GetComponent<Rigidbody2D>().AddForce(dir*70f, ForceMode2D.Impulse);
		Destroy (this.gameObject, 5);
	}

	void Update () {
			
	}
	
	public void changeMovement(){
		direction = !direction;
	}

	void OnDestroy()
	{
		Instantiate (explosion, this.gameObject.transform.position, this.gameObject.transform.rotation);
	}
}
