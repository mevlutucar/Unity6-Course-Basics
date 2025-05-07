using UnityEngine;

public class TestingScript : MonoBehaviour
{


    void Awake()
    {

    }
    void Start()
    {
        TestFnc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestFnc()
    {
        Debug.Log("Normal Log!");
        Debug.LogWarning("Warning Log!");
        Debug.LogError("Error Log!");

    }
}
