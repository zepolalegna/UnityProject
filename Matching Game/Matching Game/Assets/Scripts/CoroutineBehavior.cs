using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehavior : MonoBehaviour
{
    public bool canRun = true;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        Debug.Log("Start");
        yield return wfsObj;
        Debug.Log("Late Start");
        while (canRun)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Run on Start");
        }
    }
}
