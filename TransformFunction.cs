using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunction : MonoBehaviour {

    public float Speed = 0.1f;      // speed ໃນການເຄື່ອນໄປໜ້າ ແລະ ກັບຫຼັງ
    public float turnSpeed = 0.5f;  // speed ໃນການໝຸນ ຫຼື ລ້ຽວ

	void Update () {
		
        // ກົດ UpArrow ເພື່ອເຄື່ອນໄປຂ້າງໜ້າ
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime); // Translate ຄຳສັ່ງເຄື່ອນຍ້າຍ GameObject
            Debug.Log("Move Forward");
        }

        // ກົດ DownArrow ເພືອເຄື່ອນກັບຫຼັງ
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
            Debug.Log("Move Backward");
        }
        
        // ກົດ LeftArrow ເພື່ອນໜຸນໄປຊ້າຍ
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime); // Rotate ຄຳສັັ່ງໜູນ GameObject ຢູ່ກັັບທີ່
            Debug.Log("Turn left");
        }

        // ກົດ RightArrow ເພື່ອໜຸນໄປຂວາ
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
            Debug.Log("Turn right");
        }

	}
}
