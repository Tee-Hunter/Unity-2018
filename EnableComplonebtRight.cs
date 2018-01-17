using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComplonebtRight : MonoBehaviour {

    // ປະກາດຕົວປ່ຽນ DirectionalLight ເພື່ອເກັບຄ່າຂອງດອກໄຟ
    private Light DirectionalRoom;

    void Start()
    {
        // ປະກາດໃຊ້ ດອກໄຟດ້ວຍຄຳສັ່ງ GetComponent 
        DirectionalRoom = GetComponent<Light>();
    }


	void Update () {
        
        // ກົດ Space ເພື່ອປິດເປີດດອກໄຟ
        if (Input.GetKeyUp(KeyCode.Space))
        {
            DirectionalRoom.enabled = !DirectionalRoom.enabled;
        }

    }
}
