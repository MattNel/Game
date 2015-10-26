using UnityEngine;
using System.Collections;

public class enemy_short_move : MonoBehaviour {
	private GameObject target;
	loosingCondition theObserver;
	private bool agro = false;
	private bool facing_left = true;
	Transform child_1;
	Transform child_2;
	private Transform[] m_Side;
	[SerializeField] private LayerMask m_WhatIsGround;
	//private bool m_FacingLeft = true; 
	private Rigidbody2D m_Rigidbody2D;
	void Start () {
		m_Side = new Transform[2];
		target = GameObject.FindGameObjectWithTag ("Player");
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
		theObserver = (loosingCondition) GameObject.Find("observer").GetComponent(typeof(loosingCondition));
		child_1 = this.transform.GetChild(0);
		child_2 = this.transform.GetChild(1);

		m_Side[0] = transform.Find("LeftCheck");
		m_Side[1] = transform.Find("RightCheck");

		BoxCollider2D temp = child_2.GetComponent <BoxCollider2D> ();
		temp.enabled = false;

		SpriteRenderer spt = child_2.GetComponent <SpriteRenderer> ();
		spt.enabled = false;
	}

	void Update () {
		BoxCollider2D temp = child_1.GetComponent <BoxCollider2D> ();
		temp.enabled = false;
		
		BoxCollider2D temp1 = child_2.GetComponent <BoxCollider2D> ();
		temp1.enabled = true;

		if(!temp.enabled&&!temp1.enabled)
		{
			//temp.enabled = true;
			Debug.Log("player");
		}

		if (agro) {
			temp = child_1.GetComponent <BoxCollider2D> ();
			temp.enabled = false;

			temp1 = child_2.GetComponent <BoxCollider2D> ();
			temp1.enabled = true;

			SpriteRenderer spt = child_1.GetComponent <SpriteRenderer> ();
			spt.enabled = false;

			SpriteRenderer spt1 = child_2.GetComponent <SpriteRenderer> ();
			spt1.enabled = true;

			Vector2 difference;
			difference = (target.transform.position) - transform.position;
			difference.Normalize ();
			
			float rotz = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;

			if (transform.position.x < target.transform.position.x + 5 && transform.position.x > target.transform.position.x - 5) {
				m_Rigidbody2D.velocity = new Vector2 (0, 0);
                if(true)
                {
                    theObserver.damage();
                }
				
			} else
			if ((rotz > 90 || rotz < -90)) {

				m_Rigidbody2D.velocity = new Vector2 (m_Rigidbody2D.velocity.x - 0.5f, m_Rigidbody2D.velocity.y);
			} else
			if ((rotz < 90 && rotz > -90)) {

				m_Rigidbody2D.velocity = new Vector2 (m_Rigidbody2D.velocity.x + 0.5f, m_Rigidbody2D.velocity.y);
			}

			if(!facing_left&&(rotz > 90 || rotz < -90))
			{
				facing_left = !facing_left;
				Vector3 theScale = child_1.localScale;
				theScale.x *= -1;
				child_1.localScale = theScale;
				child_2.localScale = theScale;
			}else
			if(facing_left&&(rotz < 90 && rotz > -90)){
				facing_left = !facing_left;
				Vector3 theScale = child_1.localScale;
				theScale.x *= -1;
				child_1.localScale = theScale;
				child_2.localScale = theScale;
			}

		} else {
			temp = child_1.GetComponent <BoxCollider2D> ();
			temp.enabled = true;
			
			temp1 = child_2.GetComponent <BoxCollider2D> ();
			temp1.enabled = false;

			SpriteRenderer spt = child_1.GetComponent <SpriteRenderer> ();
			spt.enabled = true;
			
			SpriteRenderer spt1 = child_2.GetComponent <SpriteRenderer> ();
			spt1.enabled = false;

			m_Rigidbody2D.velocity = new Vector2 (0, m_Rigidbody2D.velocity.y);
		}
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
