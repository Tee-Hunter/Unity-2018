using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    // ປະກາດ Transform GameObject ເອື່ອເອີ້ນໃຊ້ດ້ວຍຕົວປ່ຽນ traget
    public Transform traget;

    void Update()
    {
        // LookAt ໃຫ້ Camera 
        transform.LookAt(traget);
    }
}
