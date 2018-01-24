using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour {

    public float range;

	void Update () {

        float h = Input.GetAxis("Horizontal");
        float xpos = h * range;

        transform.position = new Vector3(xpos, 2f, 0);
        Debug.Log("Value Return : " + h.ToString("F2"));

    }
}
