using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatments : MonoBehaviour {

    // ປະກາດຕົວປ່ຽນທາງອຸນຫະພຸມແຕ່ລະໄລຍະອົງສາ 
    public float coffeeTemperature = 100.0F;   // coffeeTemperature ເກັບຄ່າ 100 ອົງສາ celsius
    public float hotLimitTemperature = 60.0F;  // hotLimitTemperature ເກັບຄ່າ 60 ອົງສາ celsius
    public float coldLimitTemperature = 37.0F; // coldLimitTemperature ເກັບຄ່າ 37 ອົງສາ celsius

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))    // ຖ້າກົດ Space ໃຫ້ສະແດງຄ່າຕາມເງຶ່ອນໄຂ if ອອກທາງ Console
        {
            Temperature ();// ເອີ້ນໃຊ້ຟັງຊັນ Temperature
        }
        
        // Time.deltaTime : ເວລາທີ່ໃຊ້ໃນການ lander ແຕ່ລະ frame 
        coffeeTemperature -= Time.deltaTime * 5f; // ນັບຄ່າອຸນຫະພູມຈາກ 100 ລົງເລື່ອຍໄລ່ເປັນ frame rate per second 
    } 


    void Temperature ()
    {
        // ຖ້າ 100 > 60 
        if (coffeeTemperature > hotLimitTemperature)
        {
            Debug.Log("coffee is so hot to drink, please wait for a while");
        }

        // ຖ້າ 100 < 37 
        else if (coffeeTemperature < coldLimitTemperature)
        {
            Debug.Log("coffee is too cold you should warm that");
        }

        // ຖ້າ 37 < coffeeTemperature < 60 
        else
        {
            Debug.Log("coffee is ready to drink");
        }
    }
}
