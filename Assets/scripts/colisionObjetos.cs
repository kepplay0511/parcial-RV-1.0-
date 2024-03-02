using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionObjetos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barraEnergetica"))
        {
            Destroy(other.gameObject);

        }
    }
}
