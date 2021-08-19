using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2Movement : MonoBehaviour
{
    public Transform object2;

    private int movementDist = 10;

    void Update()
    {
        object2.position += movementDist * Time.deltaTime * object2.forward;
        transform.Rotate(new Vector3(0, -90 * Time.deltaTime));
    }
}
