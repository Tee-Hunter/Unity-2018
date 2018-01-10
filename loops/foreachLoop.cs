using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foreachLoop : MonoBehaviour
{

    void Start()
    {
        // ປະການຕົວປ່ນເປັນ Arry 
        string[] players = new string[3];

        // ໃສ່ຄ່າໃຫ້ກັບ Arry ແຕ່ລະ indexs
        players[0] = "First player";    // index ທີ່ 0
        players[1] = "Second player";   // index ທີ່ 1
        players[2] = "Third player";    // index ທີ່ 2

        foreach (string item in players)
        {
            print(item); // ສະແດງຄ່າຂອງການ loop ຂອງແຕ່ລະຮອບ
        }
    }
}
