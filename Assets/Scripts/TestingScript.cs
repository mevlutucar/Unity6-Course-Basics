using UnityEngine;

public class TestingScript : MonoBehaviour
{

    int repeatAmount =1;
    void Awake()
    {
        Debug.Log("Awake");
        TestFnc();
    }
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestFnc()
    {
        Debug.Log($"{repeatAmount} kez test fonksiyonu calisti.");

    }
}
