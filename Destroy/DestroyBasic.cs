using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{
	void Update ()
    {
		if (Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject); // Add Code ໃສ່ GameObject ໃດ Destroy ທຸກຢ່າງທີ່ເປັນຂອງ Game ນັ້ນ
        }
	}
}
