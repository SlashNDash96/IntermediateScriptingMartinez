using UnityEngine;
using System.Collections;

public class AppleClass1 : Fruit
{
    public AppleClass1()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    //These methods are overrides and therefore
    //can override any virtual methods in the parent
    //class.
    public void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}

