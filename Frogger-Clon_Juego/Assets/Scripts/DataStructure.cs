﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStructure : MonoBehaviour {

    // Use this for initialization
    public static DataStructure auxiliaryDataStructure;

    [HideInInspector]
    public PlayerData playerData;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (auxiliaryDataStructure == null)
        {
            auxiliaryDataStructure = this;
        }
        else if (auxiliaryDataStructure != null)
        {
            this.gameObject.SetActive(false);
        }
    }
    public struct PlayerData
    {
        public int life;
        public float score;
        public float Seconds;
        public float minutes;
    }
    public void SetPlayerData()
    {
        playerData.life = Player.InstancePlayer.GetLife();
    }
    public void SetPlayerValue()
    {
        Player.InstancePlayer.SetLife(playerData.life);
    }
}
