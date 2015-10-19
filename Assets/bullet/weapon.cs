using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;


public class weapon : MonoBehaviour {

	public float fireRate;
	public float damage;
	public float hitRadius;
	public LayerMask tohit;
	public Transform bullit;
	public Transform bullitG;
	public swap swaper;
	float fireRateG = 0.7f;

	Transform point;
	public float timeToFire = 0;
	float timeToFireG = 0;

    SoundManager sound;

	void Start () {
		point = transform.FindChild ("point");
        sound = FindObjectOfType(typeof(SoundManager)) as SoundManager;
    }
	
	// Update is called once per frame
	public void Update () {
		if (Input.GetButton ("Fire1") && Time.time > timeToFire) {
			timeToFire = Time.time + 1 / fireRate;
			Shoot ();
            sound.PlayPlayerFire();
        } else
		if(Input.GetButton ("Granade") && Time.time > timeToFireG){
			timeToFireG = Time.time + 1 / fireRateG;
			ShootGra();
		}



		if(Input.GetButtonDown ("Fire2"))
		{
			swaper.swapIt();
            sound.PlayPlayerSwap();
        }

	}


	void Shoot()
	{
	
		Transform temp = Instantiate (bullit, point.position, point.rotation) as Transform;
		GameObject temp1 = temp.gameObject;
		bulHit butScript = (bulHit) temp1.GetComponent(typeof(bulHit));
		butScript.setSwap(swaper);
		temp1.layer = 12;
		swaper.setTarget (temp1, (move) temp1.GetComponent(typeof(move)));
	}

	void ShootGra()
	{
		
		Transform temp = Instantiate (bullitG, point.position, point.rotation) as Transform;
		GameObject temp1 = temp.gameObject;
		bulHit butScript = (bulHit) temp1.GetComponent(typeof(bulHit));
		butScript.setSwap(swaper);
		temp1.layer = 12;
		swaper.setTarget (temp1, (move) temp1.GetComponent(typeof(move)));
	}

	void OnTriggerStay2D (Collider2D col)
	{
		if (Input.GetButton ("Fire3") && col.gameObject.layer == 11) {
			Destroy(col.gameObject);
		}
	}

}
