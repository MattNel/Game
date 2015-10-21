using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	void Start () {
		Destroy (gameObject,1);
	}

	void OnTriggerStay2D (Collider2D col)
	{
		if (col.gameObject.layer == 11) {
			Destroy(col.gameObject);
		}
	}
}
