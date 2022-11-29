using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array to store UFO Ships

    public int ufoIndex;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int ufoIndex = Random.Range(0,ufoPrefabs.Length); //Picks a random UFO on array
            Instantiate(ufoPrefabs[ufoIndex], new Vector3(0, 0, 15), ufoPrefabs[ufoIndex].transform.rotation); //Spawns a UFO from the array
        }
    }
}