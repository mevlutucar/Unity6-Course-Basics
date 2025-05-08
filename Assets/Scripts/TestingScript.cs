using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

namespace mevlutUcarNameSpace
{


}

public class TestingScript : MonoBehaviour
{

List<int> numbersList = new List<int>();

    void Awake()
    {

    }
    void Start()
    {
        numbersList.Add(15);
        numbersList.Add(25);
        numbersList.Add(35);
        PrintList();

        numbersList.RemoveAt(1);
        PrintList();

        numbersList.Clear();
        PrintList();
    }

    void Update()
    {
        
    }

void PrintList()
{
    /* for(int i = 0 ; i< numbersList.Count; i++)
    {
        Debug.Log($"List'te bulunan mevcut eleman: {numbersList[i]}");
    } */

    foreach(int myNumber in numbersList)
    {
        Debug.Log($"List'te bulunan mevcut eleman: {myNumber}");
    }
    Debug.Log("------------------------------");
}
    

}

