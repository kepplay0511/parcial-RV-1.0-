using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barraEnergetica : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // Reemplaza "Player" por la etiqueta del jugador
        {
            // Llama a la función para aumentar la velocidad del jugador
            other.gameObject.GetComponent<player>().GetCurrentSpeed();

            // El objeto se destruye después de ser tocado (opcional)
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
