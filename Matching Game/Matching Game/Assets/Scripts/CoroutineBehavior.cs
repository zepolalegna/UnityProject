using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(3);
        Debug.Log("Late Start");
        while (true)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Run on Start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Run");
    }
}
