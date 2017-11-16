using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour {

    public GameObject winWindow; //Objeto que representa a janela de vitória.

    //Essa função é chamada toda vez que algum outro GameObject com algum Collider entra na mesma área desse GameObject
    void OnTriggerEnter(Collider col)
    {
        Time.timeScale = 0; //Pause
        winWindow.SetActive(true); //Ativa o objeto que contem a janela de vitória.
    }


}
