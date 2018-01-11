using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class ຫຼັກ 
public class mainPlayer : MonoBehaviour {

    public int item = 5;    // item ຂອງ player

    private int unemy = 0;  // team member 
    private int level = 5;  // level of player 

    public approvePlayer shooter; // ປະກາດ Class approvePlayer

	void Start () {

        item = 30;  // ເລີ່ມເກມດ້ອຍ item = 30

        // 
        approvePlayer shooter = new approvePlayer();    // ເອີ້ນໃຊ້ Class approvePlayer
        shooter.weapon0 (item, shooter.GSF302);

	}
	
    // ສ້າງ method ໃຫ້ກັບຫົວໜ້າທີມ ສາມາດຍິງໄດ້ຫຼາຍກວ່າລຸກທີມ 
    void maintShot (int oneShot, int twiceShot) // ຮັບຄ່າຈາກ unemy ແລະ level
    {
        int shootOut; 

        shootOut = oneShot * twiceShot * item;
        Debug.Log(shootOut);
    }

	// update item of the main player ວົນລູບຕະຫຼອດເວລາເປີດເກມ ໄວຊ້າຂື້ນກັບ FPS ຂອງຄອມແຕ່ລະໜ່ວຍ
	void Update () {
        Debug.Log("Your item now is " + item);
	}
}
