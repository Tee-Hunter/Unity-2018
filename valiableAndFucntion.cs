using System.Collections;
using System.Collections.Generic;
using UnityEngine;

                    // Valiable : ຕົວປ່ຽນ ແມ່ນກ່ອງເກັບຂໍ້ມູນເຊິ່ງແຕ່ລະກ່ອງຕ້ອງເກັບຂໍ້ມູນແຕກຕ່າງກັນອອກໄປ
public class valiableAndFucntion : MonoBehaviour
{
    int score = 7;  // score : ແມ່ນຕົວປ່ຽນທີ່ເກັບຂໍ້ມູນຊະນິດເລກທົດສະນິຍົມ
    int playerScore; 

                    // Fucntion : ແມ່ນການເຮັດວຽກທີ່ແຕກຕ່າງກັນເປັນກຸ່ມເປັນໝູ່ ຫຼື ເປັນໜ່ວຍງານ ແລະ ພະແນກ E.g : ພະແນກການຄ້າແມ່ນພົວນັນເລື່ອງການຂາຍ ສ່ວນພະແນກ ການບໍລິການແມ່ນຮັບແຂກ, ສົ່ງແຂກ...
    void Start()    // ເປັນຟັງຊັນບໍ່ຮັບຄ່າບໍ່ສົ່ງຄ່າ E.g ເຮັດວຽກແຕ່ພາຍໃນໝ່ວຍງານຕົວເອັງບໍ່ໃຫ້ໝ່ວຍງານອື່ນມາພົວພັນ ແລະ ຈະບໍ່ໄປພົວພັນຫຍັງໝົດກັບໜ່ວຍງານອື່ນ.
    {
        playerScore = GameOver(score);
        Debug.Log("Player Score : " + playerScore);  // Debug.Log ສະແດງຄ່າ PlayerScore ຜ່ານທາງ Console 
    }

    int GameOver( int wholeScore)       // int ຟັຊັ້ນທັງຮັບທັງສົ່ງຄ່າໄດ້ E.g ກົງກັນຂ້າມກັບ void
    {

        playerScore = wholeScore * 5;
        return playerScore;             // return ເປັນຕົວສົ່ງຄ່າທີ່ໄດ້ຈາກການເຮັດວຽກແລ້ວກັບໄປໃຊ້ໃນຟັງຊັນອື່ນໆ E.g ໜ່ວຍງານຕີພິມ ສົ່ງເອກະສານທີ່ໜ່ອຍງານບໍລິຫານເປັນໄຟໃນ USB ມາຝາກພິມກັບຄື້ນໄປເປັນກະດາດ 
    }
}





