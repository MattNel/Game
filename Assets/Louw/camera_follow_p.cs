using UnityEngine;
using System.Collections;

public class camera_follow_p : MonoBehaviour {

	GameObject target;
	public float damping = 1;
	public float lookAheadFactor = 3;
	public float lookAheadReturnSpeed = 0.5f;
	public float lookAheadMoveThreshold = 0.1f;
	
	private float m_OffsetZ;
	private float offsetY = 0;
	private float offsetX = 0;
	private Vector3 m_LastTargetPosition;
	private Vector3 m_CurrentVelocity;
	private Vector3 m_LookAheadPos;
	private Rigidbody2D momentum;
	
	// Use this for initialization
	private void Start()
	{
		target = GameObject.FindGameObjectWithTag ("Player");
		m_LastTargetPosition = target.transform.position;
		m_OffsetZ = (transform.position - target.transform.position).z;
		transform.parent = null;
		momentum = target.GetComponent<Rigidbody2D> ();
	}
	
	
	// Update is called once per frame
	private void Update()
	{
		// only update lookahead pos if accelerating or changed direction\
		
		float xMoveDelta = (target.transform.position - m_LastTargetPosition).x;
		
		if (momentum.velocity.y > 15) {
			if(offsetY<30)
			{
				offsetY += 0.5f;
			}
		} else
		if (momentum.velocity.y < -15) {
			if(offsetY>-30)
			{
				offsetY -= 0.5f;
			}
			
		} else {
			
			if(offsetY<0)
			{
				offsetY += 0.5f;
				
			}else
				if(offsetY>0)
			{
				offsetY -= 0.5f;
			}
		}
		
		if (momentum.velocity.x > 20) {
			if(offsetX<30)
			{
				offsetX += 0.7f;
			}
		} else
		if (momentum.velocity.x < -20) {
			if(offsetX>-30)
			{
				offsetX -= 0.7f;
			}
			
		} else {
			
			if(offsetX<0)
			{
				offsetX += 0.7f;
				
			}else
				if(offsetX>0)
			{
				offsetX -= 0.7f;
			}
		}
		
		
		
		bool updateLookAheadTarget = Mathf.Abs(xMoveDelta) > lookAheadMoveThreshold;
		
		if (updateLookAheadTarget)
		{
			m_LookAheadPos = lookAheadFactor*Vector3.right*Mathf.Sign(xMoveDelta);
		}
		else
		{
			m_LookAheadPos = Vector3.MoveTowards(m_LookAheadPos, Vector3.zero, Time.deltaTime*lookAheadReturnSpeed);
		}
		
		Vector3 aheadTargetPos = target.transform.position + m_LookAheadPos + Vector3.forward*m_OffsetZ+Vector3.up*offsetY+Vector3.right*offsetX;
		
		
		
		
		Vector3 newPos = Vector3.SmoothDamp(transform.position, aheadTargetPos, ref m_CurrentVelocity, damping);
		
		transform.position = newPos;
		
		m_LastTargetPosition = target.transform.position;
		
	}
}

