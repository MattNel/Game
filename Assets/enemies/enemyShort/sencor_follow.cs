using UnityEngine;
using System.Collections;

public class sencor_follow : MonoBehaviour {

	private Transform enemy;
	private enemy_short_move scrpo;

    GameObject sound;
    private tut3Sound tut3sound;



        void Start () {
        sound = GameObject.FindGameObjectWithTag("SoundManager");
        tut3sound = sound.GetComponent<tut3Sound>();

        enemy = this.transform.parent.FindChild("enemy");
		scrpo = (enemy_short_move) enemy.gameObject.GetComponent (typeof(enemy_short_move));
	}

	void Update () {
		this.transform.position = enemy.transform.position;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.layer == 9)
		{
			scrpo.setAgroTrue ();
            tut3sound.playEnemy2();
        }
			
	}

	void OnTriggerExit2D (Collider2D col)
	{
		if(col.gameObject.layer == 9)
		{
			scrpo.setAgroFalse ();
		}
	}
}
