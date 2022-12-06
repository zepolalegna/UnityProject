using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class MoveForward : MonoBehaviour
{
    public float speed = 50.0f; 

    // Update is called once per frame
    void Update()
    {
        // Moves GameObject forward
        transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * speed);
    }
}
