using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStates : MonoBehaviour {

    //ເອື້ນໃຊ້ Activate Object ຜ່ານຕົວປ່ຽນ myGameObject
    public GameObject myGameObject;
	
	void Start ()
    {
        Debug.Log("Active seft : " + myGameObject.activeSelf);
        Debug.Log("Active in Hierarchy : " + myGameObject.activeInHierarchy);
	}
	
}
