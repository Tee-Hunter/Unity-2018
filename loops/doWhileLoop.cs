using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doWhileLoop : MonoBehaviour {

	void Start () {
        
        
        bool password = false;      // ປະກາດ ແລະ ໃສ່ຄ່າໃຫ້ເປັນ "ຜິດ" ໄວ້ກ່ອນ

        // do while loop ຈະກວກສອບ statements ຮອບໜຶ່ງກ່ອນ ຈາກນັ້ນກວດເງື່ອນໄຂ
        do
        {
            Debug.Log("Show the password");

        } while ( password == true); // ປ່ຽນຄ່າ passward ຈາກຜິດໃຫ້ເປັນຖືກ

	}
	
	
}
