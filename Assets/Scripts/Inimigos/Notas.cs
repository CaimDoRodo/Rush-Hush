using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : Inimigo
{
    void Start() 
    {
        vida = 1;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            TomarDano(1);

        }

    }

}