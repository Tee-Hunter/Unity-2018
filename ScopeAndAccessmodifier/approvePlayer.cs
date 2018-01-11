using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class approvePlayer  {

    // ປຶນສອງກະບອກນີ້ player ໃນທີມສາມາດໃຊ້ທຸກຄົນ (public scope)
    public int GSF302; // ປືນ GSF302
    public int GSF506; // ປືນ GSF506

    // ປຶນສອງກະບອກນີ້ໃຊ້ໄດ້ສະເພາະລູກທີມບາງຄົນທີ່ເປັນ ApprovePlayer ເທົ່ານັນ (local scope)
    private int H2C01; // ປືນ H2C01
    private int H7C09; // ປືນ H7C09

    // method for first weapon
    public void weapon0 (int GSF302, int GSF506) // ຮັບປືນຈາກ public scope (ປືນທີ່ຖືກກົດໝາຍສາມາດຫາໃຊ້ໄດ້ທົ່ວໄປ)
    {
        int shotOut;
        
        shotOut = GSF302 + GSF506;
        Debug.Log("Total shot : " + shotOut);
        
    }

    // method for second weapon
    private void weapon1 (int H2C01, int H7C09) // ຮັບປືນຈາກ private scope (ປືນທີ່ຜິດກົດໝາຍຕ້ອງລັກຊື້ກັນແບບລັບໆ)
    {
        int shotOut;

        shotOut = H2C01 + H7C09;
        Debug.Log("Total shot of weapon1 : " + shotOut);
    }
}
