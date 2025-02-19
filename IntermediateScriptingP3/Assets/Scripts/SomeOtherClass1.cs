using UnityEngine;
using System.Collections;

public class SomeOtherClass1 : MonoBehaviour
{
    void Start()
    {
        SomeClass1 myClass = new SomeClass1();
        myClass.GenericMethod<int>(5);
    }
}
