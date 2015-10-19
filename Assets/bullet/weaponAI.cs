using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;


public class weaponAI : MonoBehaviour {
	
	public float fireRate;
	public float damage;
	public float hitRadius;
	public LayerMask tohit;
	public Transform bullit;
	//public AudioSource enemyShootSound;
	private bool agro = false;

	Transform point;
	float timeToFire = 0;
	
	void Start () {
		point = transform.FindChild ("point");
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > timeToFire)
		{
			timeToFire = Time.time + 1/fireRate;
			Shoot ();
		}
	}
	
	void Shoot()
	{
		Transform temp = Instantiate (bullit, point.position, point.rotation) as Transform;
		GameObject temp1 = temp.gameObject;
		temp1.layer = 12;
		//enemyShootSound.Play ();
	}

	public void setAgroTrue()
	{
		agro = true;
	}
	
	public void setAgroFalse()
	{
		agro = false;
	}
}
