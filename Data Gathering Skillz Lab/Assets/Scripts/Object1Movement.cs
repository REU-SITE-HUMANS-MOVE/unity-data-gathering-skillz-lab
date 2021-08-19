using UnityEngine;

public class Object1Movement : MonoBehaviour
{
    public Transform object1;

    private int movementDist = 10;

    void Update()
    {
        object1.position += movementDist * Time.deltaTime * object1.forward;
        transform.Rotate(new Vector3(0, 90 * Time.deltaTime));
    }
}
