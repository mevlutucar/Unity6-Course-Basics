using System.Globalization;
using UnityEngine;

public class TestingScript : MonoBehaviour
{

int number = 6;
int number2 = 10;

bool isTrue = false;

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
        if(number > 6)
        {
            Debug.Log("Number is bigger than 6!");
        }
        else if (number < 6)
        {
            Debug.Log("Number is less than 6!");
        }
        else if(number > 6 || number2 <= 10)
        {
            Debug.Log("Number is 6 or Number 2 is bigger or equal to 10!");

        }
        else
        {
            Debug.Log($"Number is {number}!");
        }

        if(!isTrue)
        {
            Debug.Log("Bool is false!");

        }

    }
}
