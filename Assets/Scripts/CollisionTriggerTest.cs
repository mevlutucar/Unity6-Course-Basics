using UnityEngine;

public class CollisionTriggerTest : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }

}
