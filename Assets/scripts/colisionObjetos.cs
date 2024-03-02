using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionObjetos : MonoBehaviour
{
    public float velocidadAumento = 0.5f; // Porcentaje de aumento de velocidad

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barraEnergetica"))
        {
            Destroy(other.gameObject); // Destruye el objeto que ha colisionado

            // Aumenta la velocidad del objeto actual
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity *= (1 + velocidadAumento); // Aumento de velocidad en un 10%
            }
        }
    }
}