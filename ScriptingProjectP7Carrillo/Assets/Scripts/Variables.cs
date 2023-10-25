using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        int result;
        result = number * 2;
        return result;
    }
}
