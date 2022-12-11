using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : ScriptableObject
{
    public void CreatInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
