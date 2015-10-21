using UnityEngine;
using System.Collections;

public class statusAI : MonoBehaviour {

	public int health;
	bool shooting = true;
	bool dead = false;
	bool idol = false;
	private Animator anm;  

	void Start () {
		anm = GetComponent<Animator>();
		if(health == 0)
		{
			health = 5;
		}
		health = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {

			dead = true;
			shooting = false;
			anm.SetBool("shooting", shooting);
			anm.SetBool("dead", dead);
			Destroy (this.gameObject);
		} else {
			anm.SetBool("shooting", shooting);
			anm.SetBool("idol", idol);
		}

	}
	
	public void damage()
	{
		health--;
	}
	public void kill()
	{
		health = 0;
	}
}
