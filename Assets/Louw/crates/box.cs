using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {

	private Rigidbody2D m_Rigidbody2D;
	private Transform left;
	private Transform down;
	private Transform right;
	private Transform up;
	loosingCondition theObserver;
	GameObject player;
	public Sprite c;
	public Sprite c2;


	// Use this for initialization
	void Start () {
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
		down = gameObject.transform.FindChild ("down");
		theObserver = (loosingCondition) GameObject.Find("observer").GetComponent(typeof(loosingCondition));
		player = GameObject.Find("player");

		box_col temp;

		temp = (box_col)down.GetComponent (typeof(box_col));
		temp.setObserver (theObserver);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (1)) {
			changeOFF ();
		}
		if (Input.GetMouseButton (0)) {
			changeOFF ();
		}

		box_col temp;
		
		temp = (box_col)down.GetComponent (typeof(box_col));
		temp.setVol (m_Rigidbody2D.velocity.y);


	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(m_Rigidbody2D.velocity.x>10||m_Rigidbody2D.velocity.x<-10)
		{
			if(col.gameObject.layer == 11||col.gameObject.layer == 12)
			{
				GameObject temp = getParent(col.gameObject);
				Destroy(temp);

            }
            else
				if(col.gameObject.layer == 9)
			{
				theObserver.kill();
			}
			
		}
		
	}
	public void changeON()
	{
		this.GetComponent<SpriteRenderer>().sprite = c;
	}
	
	public void changeOFF()
	{
		this.GetComponent<SpriteRenderer>().sprite = c2;
	}
	
	// Update is called once per frame

	public GameObject getParent(GameObject tar)
	{
		Transform temp = tar.transform;
		Transform pre = null;
		while(temp != null)
		{
			pre = temp;
			temp = temp.transform.parent;
        }
		
		return pre.gameObject;
	}
}
