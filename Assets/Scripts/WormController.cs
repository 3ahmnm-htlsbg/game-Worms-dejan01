using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{

    public int x;
    public string text;

    // Start is called before the first frame update
    void Start()
    {
        /*
        if(x > 10)
        {
            Debug.Log("x ist größer als 10");

        }
        else
        {
            Debug.Log("x ist kleiner als 10");
        }

        if(text == "DEJAN"){
            Debug.Log("In der text Variable steht DEJAN");
        }
        else
        {
            Debug.Log("Es steht etwas anderes");
        }
        */

        if(x>10){
            Debug.Log("X ist größer oder gleich als 10");
        }
        else
        {
            Debug.Log("X ist kleiner oder gleich als 10");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
