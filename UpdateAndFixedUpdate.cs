using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour {

	// Update ຕາມຄວາມໄວຂອງຕອມໜ່ອຍທີ່ໃຊ້ Run
	void Update () {

        Debug.Log("Update Fucntion : " + Time.deltaTime);
	}
		
    
    // Update ເປັນ Frame Per Second ບໍ່ວ່າຈະເອົາຄອມ spec ສູງ ຫຼື ຕ່ຳມາ Run ກໍຈະໄດ້ຜົນລັບຄືກັນ 
	void FixedUpdate () {

        Debug.Log("FixedUpdate Fucntion : " + Time.deltaTime);
	}
}
