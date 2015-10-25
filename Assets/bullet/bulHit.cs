using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class bulHit : MonoBehaviour {

	swap swaper;
	public ParticleSystem expo;
	//enemy_short_move hitLeopard ;


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
		if (col.gameObject.layer == 11||col.gameObject.layer == 12) {
				
				Destroy (gameObject);
				swaper.setTarget (col.gameObject, null);
			Instantiate (expo, this.gameObject.transform.position, this.gameObject.transform.rotation);
				expo.Play();
			/*if(col.gameObject.layer == 11)
			{
				hitLeopard = (enemy_short_move)col.gameObject.GetComponentInChildren(typeof(enemy_short_move));

				hitLeopard.hitL();
			}*/
		}


	}

	void OnDestroy()
	{
		if(this.gameObject.tag == "standerdBulletG")
		{
			Debug.Log("standerdBulletG");
			Instantiate (expo, this.gameObject.transform.position, this.gameObject.transform.rotation);
			expo.Play();
		}
	}

}
