using UnityEngine;
using System.Collections;

public class init : MonoBehaviour {

	// Use this for initialization
	public Texture2D cursorTexture;
	void Start () {

        Cursor.SetCursor(cursorTexture, new Vector2(cursorTexture.width/2,cursorTexture.height/2), CursorMode.Auto);
	}
}
