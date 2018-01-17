using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossProduct : MonoBehaviour {

        Vector3 GetNormal(Vector3 x, Vector3 y, Vector3 z)
        {
            Vector3 side1 = y - x;
            Vector3 side2 = z - x;
            return Vector3.Cross(side1, side2).normalized;

            Debug.Log("Return Vector referents");

        }
    }
