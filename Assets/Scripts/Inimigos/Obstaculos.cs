using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public int VidaACurarOuTirar = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthController healthController = other.GetComponent<HealthController>();

            healthController.modificarVida(VidaACurarOuTirar);


            DestroyObject(gameObject);
        }
    }
}
