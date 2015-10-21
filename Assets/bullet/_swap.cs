//using UnityEngine;
//using System.Collections;
//namespace UnityStandardAssets._2D
//{
//	public class swap : MonoBehaviour {
//
//		GameObject target;
//		move butScript = null;
//
//		void Start () {
//			//target = new GameObject();
//		}
//		
//		// Update is called once per frame
//		void Update () {
//		
//		}
//
//		public void setTarget (GameObject inObj, move inButScript)
//		{
//			Debug.Log ("New target.");
//			target = inObj;
//			butScript = inButScript;
//		}
//
//		public void swapIt()
//		{
//			if(target != null)
//			{
//				Debug.Log ("Swap.");
//				Vector2 temp = this.transform.parent.position;
//				this.transform.parent.position = target.transform.position;
//				target.transform.position = temp;
//
//				if(butScript != null)
//				{
//					butScript.changeMovement();
//				}
//			}
//		}
//	}
//}
