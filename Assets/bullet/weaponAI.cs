using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;


public class weaponAI : MonoBehaviour {
	
	public float fireRate;
	public float damage;
	public float hitRadius;
	public LayerMask tohit;
	public Transform bullit;
	private bool agro = false;

	Transform point;
	float timeToFire = 0;

    GameObject sound;
    private tut3Sound tut3sound;

    void Start () {
        sound = GameObject.FindGameObjectWithTag("SoundManager");
        tut3sound = sound.GetComponent<tut3Sound>();
        point = transform.FindChild ("point");
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > timeToFire)
		{
			timeToFire = Time.time + 1/fireRate;
            //sDebug.Log("WTD");
			Shoot ();
		}
	}
	
	void Shoot()
	{
		Transform temp = Instantiate (bullit, point.position, point.rotation) as Transform;
		GameObject temp1 = temp.gameObject;
		temp1.layer = 12;
        tut3sound.playEnemy1();
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
