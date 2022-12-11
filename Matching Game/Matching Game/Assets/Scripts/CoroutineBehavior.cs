using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehavior : MonoBehaviour
{
    public bool canRun = true;
    IEnumerator Start()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(3);
        Debug.Log("Late Start");
        while (canRun)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Run on Start");
        }
    }
}
