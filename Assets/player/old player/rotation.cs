using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {


	public float offSet;
	public bool isPlayer;
	private GameObject target;
	private bool m_FacingLeft = true; 

	void Start()
	{
		if(!isPlayer)
		{
			target = GameObject.Find("player");
		}
	}

	// Update is called once per frame
	void Update () {
		Vector2 difference;
		if(isPlayer)
		{

			difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
			difference.Normalize ();

			float rotz = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler (0f, 0f, rotz + offSet);
			if((rotz>90||rotz<-90)&&!m_FacingLeft)
			{
				m_FacingLeft = !m_FacingLeft;
				Vector3 theScale = transform.parent.FindChild ("body").localScale;
				theScale.x *= -1;
				transform.parent.FindChild  ("body").localScale = theScale;
			}else
				if((rotz<90&&rotz>-90)&&m_FacingLeft)
			{
				m_FacingLeft = !m_FacingLeft;
				Vector3 theScale = transform.parent.FindChild ("body").localScale;
				theScale.x *= -1;
				transform.parent.FindChild  ("body").localScale = theScale;
			}
		}else{
			difference =  (target.transform.position) - transform.position;
			difference.Normalize ();
			
			float rotz = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler (0f, 0f, rotz + offSet);

			if((rotz>90||rotz<-90)&&!m_FacingLeft)
			{
				m_FacingLeft = !m_FacingLeft;
				Vector3 theScale = transform.parent.FindChild ("body").localScale;
				theScale.x *= -1;
				transform.parent.FindChild  ("body").localScale = theScale;
			}else
				if((rotz<90&&rotz>-90)&&m_FacingLeft)
			{
				m_FacingLeft = !m_FacingLeft;
				Vector3 theScale = transform.parent.FindChild ("body").localScale;
				theScale.x *= -1;
				transform.parent.FindChild  ("body").localScale = theScale;
			}
		}

	}

}
