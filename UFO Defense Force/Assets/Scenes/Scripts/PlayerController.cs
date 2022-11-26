using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to receive values from horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        
        //Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
