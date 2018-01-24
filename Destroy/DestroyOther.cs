using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{

    public GameObject other;
	
	void Update ()
    {
	    if (Input.GetKey(KeyCode.A))
        {
            Destroy(other);
            Debug.Log("Other Destroy"); // ສາມາດເລືກ Destroy GameObject ໄດ້ຕາມໃຈ one by one or multiple by multiple 
        }	
	}
}
