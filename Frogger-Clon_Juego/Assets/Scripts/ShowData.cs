﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowData : MonoBehaviour {

    // Use this for initialization
    public Text puntaje;
    public Text time;
	void Start () {
        puntaje.text = "Puntaje: " + DataStructure.auxiliaryDataStructure.playerData.score;
        if (DataStructure.auxiliaryDataStructure.playerData.Seconds >= 10)
        {
            time.text = "Tiempo: " + DataStructure.auxiliaryDataStructure.playerData.minutes + ":" + (int)DataStructure.auxiliaryDataStructure.playerData.Seconds;
        }
        else
        {
            time.text = "Tiempo: " + DataStructure.auxiliaryDataStructure.playerData.minutes + ":0" + (int)DataStructure.auxiliaryDataStructure.playerData.Seconds;
        }

    }
    public void Siguiente()
    {
        SceneManager.LoadScene("Pantalla De Carga");
    }
}
