using UnityEngine;

public class InputManager : MonoBehaviour
{

    [SerializeField] GameObject sphereObject;



    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            sphereObject.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            sphereObject.SetActive(false);
        }
    }
}
