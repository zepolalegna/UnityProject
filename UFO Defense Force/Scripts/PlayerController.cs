using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;

    public GameObject laserBolt;
    

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        
        
        transform.Translate(UnityEngine.Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.x < -xRange )
        {
            transform.position = new UnityEngine.Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange )
        {
            transform.position = new UnityEngine.Vector3(xRange, transform.position.y, transform.position.z); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBolt, blaster.position, laserBolt.transform.rotation);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
