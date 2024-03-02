using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float tiempoInicial = 60f; // Tiempo inicial en segundos
    private float timer;
    public Text textoTimer;
    public GameObject panelGameOver; // Panel que se mostrará al finalizar el tiempo
    private bool tiempoTerminado = false;

    void Start()
    {
       
            timer = tiempoInicial;
            panelGameOver.SetActive(false); // Desactivar el panel de Game Over al iniciar el juego
        

    }

    void Update()
    {
        if (!tiempoTerminado)
        {
            timer -= Time.deltaTime;
            textoTimer.text = Mathf.RoundToInt(timer).ToString();

            if (timer <= 0)
            {
                tiempoTerminado = true;
                MostrarPanelGameOver();
                Time.timeScale = 0f; // Pausar el juego al finalizar el tiempo
            }
        }
    }

    void MostrarPanelGameOver()
    {
        panelGameOver.SetActive(true); // Mostrar el panel de Game Over
    }
}
