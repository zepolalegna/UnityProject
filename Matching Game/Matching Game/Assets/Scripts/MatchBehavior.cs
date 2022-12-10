using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    private ID otherID;

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj != null) otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
    }
}