﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponent : MonoBehaviour
{

	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Destroy(GetComponent<MeshRenderer>()); // Destroy ແຕ່ GameObject ເທົ່ານັ້ນ
        }
	}
}
