using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class bulHit : MonoBehaviour {

	swap swaper;
	public ParticleSystem expo;
    private GameObject sounds;
    private tut3Sound tut3sound;
    //enemy_short_move hitLeopard ;



    public void Start()
    {
        sounds = GameObject.FindGameObjectWithTag("SoundManager");
        tut3sound = sounds.GetComponent<tut3Sound>();
    }

	public void setSwap(swap inSwaper)
	{
		swaper = inSwaper;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.layer == 10||col.gameObject.layer == 13) {

			Destroy (gameObject);
			Instantiate (expo, this.gameObject.transform.position, this.gameObject.transform.rotation);
			expo.Play();
		} else
		if (col.gameObject.layer == 11||col.gameObject.layer == 12||col.gameObject.layer == 16) {
				
				Destroy (gameObject);
				swaper.setTarget (col.gameObject, null);
				Instantiate (expo, this.gameObject.transform.position, this.gameObject.transform.rotation);
				expo.Play();
                if(col.gameObject.layer == 16)
                {
                    tut3sound.playCrate();
                }

        }
	}

	void OnDestroy()
	{
		if(this.gameObject.tag == "standerdBulletG")
		{
			Instantiate (expo, this.gameObject.transform.position, this.gameObject.transform.rotation);
            tut3sound.playGrenadeFallStop();
            tut3sound.playGrenade();
        }
	}

}
