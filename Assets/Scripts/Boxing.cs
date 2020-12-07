using System.Collections;
using System.Collections.Generic;
using UnityEngine;
interface ISomeInterface
{
    void Call();
}
struct SomeStruct : ISomeInterface
{
    public void Call()
    {
        Debug.Log("call");
    }
}
public class Boxing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var someStruct = new SomeStruct();
        SomeMethod(someStruct);

    }
    void SomeMethod(SomeStruct someStruct)
    {
        someStruct.Call();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

}
