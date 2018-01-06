using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviorScript : MonoBehaviour {

	
	void Start () {
		
	}
	
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
