using UnityEngine;
using System.Collections;

public class loosingCondition : MonoBehaviour {

	public int health;
	public GameObject thePlayer;
	float barUnit = 199f;
	public RectTransform bar;
    SoundManager sound;

	void Start () {
		if(health == 0)
		{
			health = 5;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(health<0)
		{
			Destroy(thePlayer);
			Application.LoadLevel("level3");
		}
	}

	public void damage()
	{
		health--;
		bar.sizeDelta = new Vector2 ((barUnit -= 39.8f), 27);
        //sound.PlayPlayerDamage();
	}
}
