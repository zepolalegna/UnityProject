using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        yield return new WaitForFixedUpdate();
        draggable = true;
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }
}
