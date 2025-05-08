using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;



public class TestingScript : MonoBehaviour
{

[SerializeField] private int variable = 5;

[SerializeField] List<int> numbers = new List<int>();
    public void MyFnc()
    {
        Debug.Log($"My public function works! Variable value is: {variable}");

        Debug.Log($"First number value of the list is:{numbers[0]}");

    }

    void Start()
    {
        MyFnc();
    }

}

