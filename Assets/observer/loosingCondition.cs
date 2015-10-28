using UnityEngine;
using System.Collections;

public class loosingCondition : MonoBehaviour {

	public int health;
	float barUnit = 199f;
	public GameObject thePlayer;
	public RectTransform bar;
	//public Animator anim;

    private GameObject sounds;
    private tut3Sound tut3sound;
	private bool cantDie = false;

        void Start ()
        {
            sounds = GameObject.FindGameObjectWithTag("SoundManager");
            tut3sound = sounds.GetComponent<tut3Sound>();

            if (health >= 0)
		    {
			    health = 20;
		    }
		    barUnit = 199;
		    //anim = thePlayer.GetComponent<Animator>();
        }
	
	// Update is called once per frame
	void Update () {
		if(health<=0&&!cantDie)
		{
			//Destroy(thePlayer);
			//Application.LoadLevel(Application.loadedLevel);
		}

		if (Input.GetButton ("god")) {
			toggleNOKILL();
		}
	}

	public void toggleNOKILL()
	{
		cantDie = !cantDie;
	}

	public void damage()
	{
		health--;
		bar.sizeDelta = new Vector2 ((barUnit -= 9.95f),27);
		tut3sound.playDamage();
	}
	
		public void kill()
	{
		health = 0;
	}
}
