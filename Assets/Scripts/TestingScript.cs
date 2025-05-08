using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class TestingScript : MonoBehaviour
{

int number = 10;
    void Awake()
    {

    }
    void Start()
    {
        //ForLoopFnc();
        //WhileLoopFnc();
        DoWhileLoopFnc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ForLoopFnc()
    {

        for(int i = 0; i<10; i++)
        {
            Debug.Log($"For döngüsü, yazdırılan i = {i}");
        }
    }

    void WhileLoopFnc()
    {
        while(number > 0)
        {
            Debug.Log($"While döngüsü, şu anki sayı değeri: {number}");
            number--;
        }
    }

    void DoWhileLoopFnc()
    {
        do
        {
            Debug.Log($"Do-While döngüsü, şu anki sayı değeri: {number}");
            number--;
        }
        while(number > 0);
    }

    }

