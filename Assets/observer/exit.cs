using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {
	protected bool win= false;

	public bool getWin(){
		return win;
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.layer == 9)
		{
			win = true;
			//Application.LoadLevel("end");
		}
	}
}