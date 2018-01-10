using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileLoop : MonoBehaviour {

    // ຈຳນອນຂອງສັດຕູ
    int numEnemies = 3;

    void Start () {

        // ເລີ່ມວົນລຸບຈາກ 3 ລົງຮອດ 0
		while ( numEnemies >= 0)
        {
            Debug.Log("Enemy number is " + numEnemies);

            numEnemies--;   // ລົດຄ່າຂອງ numEnemiys ລົງໃນແຕ່ລະຮອບ
        }
	}
	
	
}
