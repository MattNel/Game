using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.layer == 9)
		{
			Application.LoadLevel("end");
		}
	}
}