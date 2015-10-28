using System;
using UnityEngine;

//namespace UnityStandardAssets._2D
//{
	public class Platformer2dChar : MonoBehaviour
	{
		private float m_MaxSpeed = 50f;
		private float m_MaxSpeedAir = 50f;  // The fastest the player can travel in the x axis.
		//private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
		
		private Animator m_Anim;            // Reference to the player's animator component.
		private Rigidbody2D m_Rigidbody2D;
		private float cur_momentum = 0f;
		//private int time_in_air;
		
		//Transform playerGraphics;
		
		private void Awake()
		{
			
			//time_in_air = 0;
			m_Anim = GetComponent<Animator>();
			m_Rigidbody2D = GetComponent<Rigidbody2D>();
			//playerGraphics = transform.FindChild ("body");
		}
		
		
		
		private void FixedUpdate()
		{

		}	
		public void Move(float move, bool jump, bool m_Grounded)
		{
			m_Anim.SetBool("Ground", m_Grounded);
		
			m_Anim.SetFloat("vSpeed", m_Rigidbody2D.velocity.y);

			m_Anim.SetBool("Crouch", false);
			
			if (!m_Grounded&&(Input.GetButton ("Horizontal"))) {
				
			m_Rigidbody2D.velocity = new Vector2 (((move * m_MaxSpeedAir)), m_Rigidbody2D.velocity.y);
				//cur_momentum = move * (m_MaxSpeedAir);
			} else 
			if (m_Grounded&&(Input.GetButton ("Horizontal"))) {
				m_Anim.SetFloat ("Speed", Mathf.Abs (move));
				m_Rigidbody2D.velocity = new Vector2 (move * m_MaxSpeed, m_Rigidbody2D.velocity.y);
				cur_momentum = move * m_MaxSpeed;
				
			} else 
				if(m_Grounded)
			{


				if(m_Rigidbody2D.velocity.x > 0)
				{
					m_Anim.SetFloat ("Speed", 0f);
					m_Rigidbody2D.velocity = new Vector2 (m_Rigidbody2D.velocity.x-0.5f, m_Rigidbody2D.velocity.y);
				}else
					if(m_Rigidbody2D.velocity.x < 0)
				{
					m_Anim.SetFloat ("Speed", 0f);
					m_Rigidbody2D.velocity = new Vector2 (m_Rigidbody2D.velocity.x+0.5f, m_Rigidbody2D.velocity.y);
				}
			}

			if (m_Grounded && jump && m_Anim.GetBool ("Ground")) {
				m_Anim.SetBool ("Ground", m_Grounded);
				m_Rigidbody2D.AddForce (new Vector2 (0f, 1500f));


			} 
		}
		
	}
	
	
//}
