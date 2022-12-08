using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;

    public int scoreToGive;
    [SerializeField] private AudioSource UFODestruction;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        UFODestruction.Play();
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(gameObject); //Destroy this game object 
        Destroy(other.gameObject); //Destroys other game abject
   
    }
}
