using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

//namespace UnityStandardAssets._2D
//{
	[RequireComponent(typeof (Platformer2dChar))]
	public class p2uc : MonoBehaviour
	{
	private Platformer2dChar m_Character;
		private bool m_Jump;
		private Transform m_GroundCheck;
		private Transform[] m_Side; // A position marking where to check if the player is grounded.
		const float k_GroundedRadius = .5f; // Radius of the overlap circle to determine if grounded
		private bool m_Grounded;            // Whether or not the player is grounded.
		//private Transform m_CeilingCheck;   // A position marking where to check for ceilings
		const float k_CeilingRadius = .01f; // Radius of the overlap circle to determine if the player can stand up
		[SerializeField] private LayerMask m_WhatIsGround; 
		
		private void Awake()
		{
			m_Side = new Transform[2];
			m_GroundCheck = transform.Find("GroundCheck");
			//m_CeilingCheck = transform.Find("CeilingCheck");
			m_Side[0] = transform.Find("LeftCheck");
			m_Side[1] = transform.Find("RightCheck");
			m_Character = GetComponent<Platformer2dChar>();
		}
		
		
		private void Update()
		{
			if (!m_Jump)
			{
				// Read the jump input in Update so button presses aren't missed.
				m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			}


		}
		
		
		private void FixedUpdate()
		{
			// Read the inputs.
			
			float h = CrossPlatformInputManager.GetAxis("Horizontal");
			
			if(isLeft() && h<0)
			{
				h = 0;
			}else
			if(isRight() && h>0){
				h = 0;
			}
			
			m_Character.Move(h, m_Jump, isGrounded());
			m_Jump = false;
		}
		
		private Boolean isGrounded()
		{
			Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
			for (int i = 0; i < colliders.Length; i++)
			{
				if (colliders[i].gameObject != gameObject)
					return true;
			}
			
			return false;
		}
		
		private Boolean isLeft()
		{
			Collider2D[] colliders = Physics2D.OverlapCircleAll(m_Side[0].position, k_GroundedRadius, m_WhatIsGround);
			for (int i = 0; i < colliders.Length; i++)
			{
			if (colliders[i].gameObject != gameObject && colliders[i].gameObject.layer != 11&& colliders[i].gameObject.layer != 9 && colliders[i].gameObject.layer != 15&&colliders[i].gameObject.layer != 17)
				{
                    return true;
				}
			}
			
			return false;
		}
		private Boolean isRight()
		{
			Collider2D[] colliders = Physics2D.OverlapCircleAll(m_Side[1].position, k_GroundedRadius, m_WhatIsGround);
			for (int i = 0; i < colliders.Length; i++)
			{
			if (colliders[i].gameObject != gameObject&&colliders[i].gameObject.layer != 11&& colliders[i].gameObject.layer != 9&&colliders[i].gameObject.layer != 15&&colliders[i].gameObject.layer != 17)
			    {
                        return true;
                }
			}
			
			return false;
		}
	}
//}
