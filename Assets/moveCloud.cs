using UnityEngine;
using System.Collections;

public class moveCloud : MonoBehaviour {
	public float tmp=0;
	public float tmp2=0;
	public bool rht=true;
	// Use this for initialization
	void Start () {
		tmp = transform.position.x + 30;
		tmp2 = transform.position.x - 30;
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x <= tmp && rht)
			transform.Translate (Vector2.right * Time.deltaTime * 1.7f);
		else {
			rht = false;
			if(transform.position.x >= tmp2)
				transform.Translate (Vector2.left * Time.deltaTime * 1.7f);
			else
				rht = true;
		}
	}
}
