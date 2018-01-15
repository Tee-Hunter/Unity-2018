using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour {

    // ຈະລັນທັນທີ່ເມື່ອ code ເລີ່ມທຳງານ ບໍ່ຈຳເປັນຕ້ອງເອີ້ນໃຊ້ GameObject ກໍສາມາໃຊ້ງານໄດ້
    void Awake()
    {
        Debug.Log("The Awake Fuction");
    } 

	// ຄ້າຍຄືກັບ Awake ແຕ່ຈະທຳງານກໍຕໍ່ເມື່ອ GameObject ຖືກເອີ້ນໃຊ້
	void Start ()
    {
        Debug.Log("The Start Fuction");
	}
	
	
}
