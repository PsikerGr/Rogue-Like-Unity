﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private GameManager instance;
    public GameManager Instance
    {
        get
        {
            if (!instance)
                instance = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

            return instance;
        }
    }

    public enum GameState
    {
        Intro = 0,
        MainMenu,
        InGame,
        Pause,
        Death,
        StateNb
    }

	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (GameObject.FindGameObjectsWithTag("GameManager").Length == 1)
            DontDestroyOnLoad(this);
	}
	

}
