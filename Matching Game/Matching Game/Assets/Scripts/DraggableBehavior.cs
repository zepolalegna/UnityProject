using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true;
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }
}
