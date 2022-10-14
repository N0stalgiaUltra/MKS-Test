using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Generic Factory Interface
/// </summary>
/// <typeparam name="T"> Any Type of Object</typeparam>
public interface IGenericFactory<T> 
{
    public T GetNewInstance();
}
