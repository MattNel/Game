using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	void Start () {
		Destroy (gameObject,1);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
			Rigidbody2D temp;
			temp = col.gameObject.GetComponent<Rigidbody2D>();
		if(temp != null&&col.gameObject.layer!=12)
		{
			if(temp != null&&col.gameObject.layer==16)
			{
				temp.AddForce(getDirection(col.gameObject)*4000f*-1,ForceMode2D.Impulse);
			}else
			{
				temp.AddForce(getDirection(col.gameObject)*100f*-1,ForceMode2D.Impulse);
			}
		}
	}

	public Vector2 getDirection(GameObject target)
	{
		
		
		Vector2 dir = transform.position - target.transform.position;
		dir.Normalize();
		
		return dir;
	}
}
