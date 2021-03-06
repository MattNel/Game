using UnityEngine;
using System.Collections;
namespace UnityStandardAssets._2D
{
	public class swap : MonoBehaviour {
		
		GameObject target;
		GameObject player;
		move butScript = null;
		
		void Start () {
			//target = new GameObject();
			player = GameObject.FindGameObjectWithTag ("Player");
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		public void setTarget (GameObject inObj, move inButScript)
		{
			//			Debug.Log ("New target.");
			target = inObj;
			butScript = inButScript;
		}
		
		
		//public AudioSource swapSound;
		public ParticleSystem effect1;
		public ParticleSystem effect2;
		Vector3 currLocation;
		Vector3 direction;
		
		public void swapIt()
		{
			if(target != null)
			{
				effect1.transform.position = player.transform.position;
				//Swap effects
				effect1.Play ();

				effect2.transform.position = target.transform.position;
				effect2.Play ();
				//Swap sound
				//swapSound = this.GetComponent<AudioSource>();
				//swapSound.Play();
				
				////////////////////Adding force in direction of swap/////////////
				currLocation = player.transform.position; 
				direction = getDirection(player,target);
				Debug.Log ("direction b4: "+ direction+"this is current loc: "+currLocation);
				
				//////////////////////////////////////////////////////////////////
				
				//				Debug.Log ("Swap.");
				Vector2 temp = this.transform.parent.position;
				this.transform.parent.position = target.transform.position;
				target.transform.position = temp;

				///////////////Adding force in direction of swap/////////////////
				player.GetComponentInParent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
				player.GetComponentInParent<Rigidbody2D>().AddForce(getDirection(player,target)*50f,ForceMode2D.Impulse);
				Debug.Log ("This is direction: "+direction);
				/////////////////////////////////////////////////////////////////
				if(butScript != null)
				{
					butScript.changeMovement();
				}
			}
		}
		public Vector2 getDirection(GameObject player, GameObject target)
		{
		
			var heading = target.transform.position - player.transform.position;
			var distance = heading.normalized;
			
			/*if(distance == 0)
				result = heading;
			else
				result = heading / distance;*/
			

			Vector2 dir = player.transform.position - target.transform.position;
			dir.Normalize();
			
			return dir;
		}
	}
}
