using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
