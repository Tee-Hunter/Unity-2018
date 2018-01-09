using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviorScript : MonoBehaviour {

	
	void Start () {
		
	}
	
    void Update () {

        // You can free to set the key press. Just change "Keycode.[ THE KEY YOU WANT TO SET ]"
        if (Input.GetKeyDown(KeyCode.Space)) //When pressing "Space" on keyboard player going to be red collor.
        { 
            GetComponent<Renderer>().material.color = Color.red; 
        }
        if (Input.GetKeyDown(KeyCode.R)) //Pressing "R" Player going to be blue collor
        {
            GetComponent<Renderer>().material.color = Color.blue; 
        }
        if (Input.GetKeyDown(KeyCode.E)) //Pressing "E" Player going to be yellow collor
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.W)) //Pressing "W" Player going to be green collor
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
