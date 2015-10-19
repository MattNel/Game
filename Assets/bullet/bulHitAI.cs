using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class bulHitAI : MonoBehaviour {

	loosingCondition theObserver;
	public ParticleSystem expo;

	void Start () {
		theObserver = (loosingCondition) GameObject.Find("observer").GetComponent(typeof(loosingCondition));;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.layer == 9) {
			Instantiate (expo, this.gameObject.transform.position, this.gameObject.transform.rotation);
			expo.Play();
			theObserver.damage();
			Destroy (gameObject);

		} else
		if (col.gameObject.layer == 10) {
			Instantiate (expo, this.gameObject.transform.position, this.gameObject.transform.rotation);
			expo.Play();
			Destroy (gameObject);

		} else
		if (col.gameObject.layer == 11) {
			Instantiate (expo, this.gameObject.transform.position, this.gameObject.transform.rotation);
			expo.Play();
			//statusAI temp = (statusAI) col.gameObject.GetComponent(typeof(statusAI));
			//temp.damage();
			//Destroy (gameObject);
		}
	}
	
}
