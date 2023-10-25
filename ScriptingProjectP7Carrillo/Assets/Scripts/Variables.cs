using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int myInt = 5;
    private int number;

    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    private int MultiplyByTwo(int myInt)
    {
        throw new NotImplementedException();
    }

    int Update()
    {
        int result;
        result = number * 2;
        return result;
    }
}
