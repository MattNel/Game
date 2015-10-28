using UnityEngine;
using System.Collections;

public class box_col : MonoBehaviour {

	private loosingCondition theObserver;
	private float vol = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if(vol < -10)
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

	public void setObserver(loosingCondition inObserver)
	{
		theObserver = inObserver;
	}

	public void setVol(float inVol)
	{
		vol = inVol;

	}
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
