using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicSybtax : MonoBehaviour {

	void Start()
    {
        
        Debug.Log(transform.position.x); // transform.position.x ແມ່ນຕົວບອກຕຳແໜ່ງການໝູນຂອງ gameObject

        if (transform.position.x <= 5) // if ເປັນເງື່ອນໄຂ ຖ້າ (transform.position.x ນ້ອຍກວ່າ ຫຼື ເທົ່າກັບ 5) ສະແດງ Console { ຂ້ອຍໃກ້ຕົກດິນແລ້ວ } 
        {
            Debug.Log("I am almost on the ground");
        }
    } 
}
