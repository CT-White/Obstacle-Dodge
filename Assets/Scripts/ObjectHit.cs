using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("You hit an object!");
    }
}
