using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        
    }
    //Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            EndGame(); //Start endgame method
        }
        else
            gameOverText.gameObject.SetActive(false); //Keep UI Text hidden
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; //freeze time
    }
}