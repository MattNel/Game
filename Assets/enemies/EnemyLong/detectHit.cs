using UnityEngine;
using System.Collections;

public class detectHit : MonoBehaviour {

	bool dia;
	// Use this for initialization
	void Awake () {
		dia = false;
		
	}
	void Start () {
		dia = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	if (!dia) {
			this.gameObject.SetActive (false);
		} else if (dia) {
			this.gameObject.SetActive(true);
		}
	}
	public void onDia ()
	{
		dia = true;
	}

	public void offDia()
	{
		dia = false;
	} 
}
