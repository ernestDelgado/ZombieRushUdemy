﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Canvas gameOverCanvas;

    private bool playerActive = false;
    private bool gameOver = false;
    private bool gameStarted = false;

    public bool PlayerActive
    {
        get { return playerActive; }
    }
    public bool GameOver
    {
        get { return gameOver; }
    }

    public bool GameStarted
    {
        get { return gameStarted; }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        Assert.IsNotNull(mainMenu);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerCollided()
    {
        gameOver = true;
        gameOverCanvas.enabled = true;
    }
    public void PlayerStartedGame()
    {
        playerActive = true;
        gameOverCanvas.enabled = false;
    }

    public void EnterGame()
    {
        mainMenu.SetActive(false);
        gameStarted = true;
    }

    
}