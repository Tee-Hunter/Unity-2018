using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeys : MonoBehaviour
{

    public GUITexture graphic;

    public Texture2D standard;
    public Texture2D downKey;
    public Texture2D upKey;
    public Texture2D heldKey;


	void Start ()
    {
        graphic.texture = standard; 
	}
	

	
	void Update ()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);

        if (down)
        {
            graphic.texture = downKey;
            Debug.Log("Key Down");
        }

        else if (held)
        {
            graphic.texture = heldKey;
            Debug.Log("Key Held");
        }

        else if (up)
        {
            graphic.texture = upKey;
            Debug.Log("Key Up");
        }

        else
        {
            graphic.texture = standard;
        }

    }
}








