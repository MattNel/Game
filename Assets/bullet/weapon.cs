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
	float timeToFire = 0;
	float timeToFireG = 0;

    private GameObject sounds;
    private MainMenuSoundManager tut3sound;

    void Start () {
		point = transform.FindChild ("point");

        sounds = GameObject.FindGameObjectWithTag("SoundManager");
        tut3sound = sounds.GetComponent<MainMenuSoundManager>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time > timeToFire) {
			timeToFire = Time.time + 1 / fireRate;
			Shoot ();
            tut3sound.playShoot();
        } else
		if(Input.GetButton ("Granade") && Time.time > timeToFireG){
			timeToFireG = Time.time + 1 / fireRateG;
			ShootGra();
            tut3sound.playGrenadeFall();
		}

		if(Input.GetButtonDown ("Fire2"))
		{
			swaper.swapIt();
            tut3sound.playSwap();
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
