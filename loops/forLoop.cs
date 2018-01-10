using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forLoop : MonoBehaviour {

    // ປະກາດຈຳນວນສັດຕູ
    int EnemiesAmound = 7;

    void Start () {

        // ວົນລູບເລີ່ມແຕ່ 0 ຫາ 7
        for (int i = 0; i <= EnemiesAmound; i++)
        {
            Debug.Log("There are " + i + " enemies now"); // console ແລະ ປ່ຽນຄ່າຕ່າມຈຳນວນຮອບລຸບ
        }
	}
	
}
