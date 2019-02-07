﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Use this for initialization
    [HideInInspector]
    public static GameManager InstanceGameManager;
    [HideInInspector]
    public bool pause;
    public GameObject camvasMenuPause;
    public GameObject camvasPlayer;
    private void Start()
    {
        InstanceGameManager = this;
        pause = false;
        camvasMenuPause.SetActive(false);
        //CursorOff();
    }

    // Update is called once per frame
    void Update ()
    {
        CheckCursor();
        CheckPause();
    }
    public void CheckCursor()
    {
        if(Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.C))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void CursorOff()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void CheckPause()
    {
        if(pause)
        {
            Time.timeScale = 0;
        }
        if(!pause)
        {
            Time.timeScale = 1;
        }
    }
    public void SetPause(bool _pause)
    {
        pause = _pause;
        if(pause)
        {
            camvasMenuPause.SetActive(true);
        }
        else
        {
            camvasMenuPause.SetActive(false);
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
