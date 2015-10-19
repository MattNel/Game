using UnityEngine;
using System.Collections;

public class sencor_shoot : MonoBehaviour {
	
	private Transform enemy;
	private weaponAI scrpo;
	
	void Start () {
		enemy = this.transform.parent.FindChild("armAI");
		scrpo = (weaponAI) enemy.gameObject.GetComponent (typeof(weaponAI));
	}
	
	void Update () {
		this.transform.position = enemy.transform.position;
	}
	
	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.layer == 9)
		{
			scrpo.setAgroTrue ();
		}
		
	}
	
	void OnTriggerExit2D (Collider2D col)
	{
		if(col.gameObject.layer == 9)
		{
			scrpo.setAgroFalse ();
		}
	}
}
