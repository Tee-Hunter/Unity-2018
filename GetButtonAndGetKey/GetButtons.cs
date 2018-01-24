using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButtons : MonoBehaviour {

    public GUITexture graphic;

    public Texture2D standard;
    public Texture2D downKey;
    public Texture2D upKey;
    public Texture2D heldKey;

	void Start () {
        graphic.texture = standard;
	}
	
	
	void Update () {

        bool down = Input.GetButtonDown("Jump");
        bool up = Input.GetButtonUp("Jump");
        bool held = Input.GetButton("Jump");

        if (down)
        {
            graphic.texture = downKey;
            Debug.Log("Key is Down");
        }

        else if (held)
        {
            graphic.texture = heldKey;
            Debug.Log("Key is Held");
        }

        else if (up)
        {
            graphic.texture = upKey;
            Debug.Log("Key is Up");
        }

        else
        {
            graphic.texture = standard;
        }

	}
}
