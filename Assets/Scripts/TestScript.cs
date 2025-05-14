using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        rb.useGravity=false;
    }

}
