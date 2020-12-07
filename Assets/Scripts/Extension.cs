using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IApiSetupAProvider
{
    void SetupObjectA();
}

public interface IApiSetupBProvider
{
    void SetupObjectB();
}

public struct ApiSetupA : IApiSetupAProvider
{
    public void SetupObjectA()
    {
      
    }
}

public struct ApiSetupB : IApiSetupBProvider
{
    public void SetupObjectB()
    {
       
    }
}
public struct ApiSetup<T>
{ }
class Api
{
    public IApiSetupAProvider For(ISomeInterfaceA objectA)
    {
        return new ApiSetupA();
    }

    public IApiSetupBProvider For(ISomeInterfaceB objectB)
    {
        return new ApiSetupB();
    }
   /* public ApiSetup<T> For<T>(T obj)
    {
        return new ApiSetup<T>();
    }*/
}
interface ISomeInterfaceA
{
 
}
interface ISomeInterfaceB
{
  
}
public  class ObjectA : ISomeInterfaceA
{ 
   
}
public class ObjectB : ISomeInterfaceB
{
   
}
/*public class Generic<T>
{

}*/
class SomeClass
{
    
    public void Setup()
    {
        Api apiObject = new Api();

        var objectA = new ObjectA();
        var objectB = new ObjectB();

        apiObject.For(objectA).SetupObjectA();
        apiObject.For(objectB).SetupObjectB();
    }

}
