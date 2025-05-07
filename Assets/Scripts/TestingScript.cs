using System.Globalization;
using UnityEngine;

public class TestingScript : MonoBehaviour
{

int number = 5;

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
        switch(number)
        {
            case 3:
            Debug.Log("Number is 3!");
            break;

            case 6:
            Debug.Log("Number is 6!");
            break;

            default:
            Debug.Log("Not entered any case!");
            break;
        }

    }
}
