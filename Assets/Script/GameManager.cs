using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
    public float startTime = 60.0f; //Variavel que define o tempo que o Timer começa.
    private float timer; //Variavel usada para atualizar nosso Timer.
    private int iTimer; //Variavel que transforma nosso timer de float para int (para ser melhor vizualizado.

    public Text timerText; //Objeto de texto que mostra nosso Timer na tela. Para funcionar é importante adicionar a linha UnityEngine.UI no começo do codigo.

    public GameObject looseWindow; //Janela que vai ser ativada quando o jogador perder.


    void Start()
    {
        //Atribuição inicial do jogo para que o timer comece.
        timer = startTime;
    }

    void Update()
    {
        if (timer > 0)
        {
            Timer();
        }
        else
        {
            YouLoose();
        }
    }

    //Essa função deve ser declarada como publica para ser acessada pelos botoes da janela de vitória/derrota.
    public void Restart()
    {
        //Time.timeScale = 1; //Variável que define o ritmo de jogo. Se aumentada para 2 o jogo rodara 2x mais rápido por exemplo.
        Application.LoadLevel(Application.loadedLevel); //Função que carrega uma nova fase. No caso colocamos como parametro a fase que já está carregada, então ela só dá um reload na fase.
    }

    //Essa função deve ser declarada como publica para ser acessada pelos botoes da janela de vitória/derrota.
    public void Exit()
    {
        Application.Quit(); //Função que fecha o jogo.
    }

    void YouLoose()
    {
        looseWindow.SetActive(true); //Desativa o objeto de janela. Pode fazer o oposto se trocar true por false.
        Time.timeScale = 0; //Quando o ritmo do jogo recebe 0 ele pausa.
    }

    void Timer()
    {
        timer -= Time.deltaTime; //Timer está recebendo o intervalo de tempo em segundos entre um frame e outro (Time.deltaTime).

        iTimer = (int)timer; //iTimer recebe timer "castado" como int. É como se o float timer fosse transformado em int e atribuido ao iTimer.

        timerText.text = iTimer.ToString(); //timerText.text recebe iTimer transformado em string.
    }
}