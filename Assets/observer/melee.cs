using UnityEngine;
using System.Collections;

public class melee : MonoBehaviour {

	void OnTriggerStay2D (Collider2D col)
	{
		if(Input.GetButton ("Fire1")&&col.gameObject.layer == 11)
		{
			//statusAI scr = (statusAI) col.gameObject.GetComponent(typeof(statusAI));
			//scr.kill();
			Destroy(col.gameObject);
		}
	}
}
