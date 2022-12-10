using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        { 
            var otherID = other.GetComponent<IDContainerBehavior>().idObj;
            if (otherID == idObj)
            {
                Debug.Log("Matched");
            }
        }
    }
}