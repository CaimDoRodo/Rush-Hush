using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public int vida ;

    

    public void TomarDano(int quantidade)
    {
        vida -= quantidade;
        Debug.Log("Recebeu Dano");
        if (vida <= 0)
        {
            Morre();

        }
    }
    public virtual void Morre()
    {
        Debug.Log("Perfeito");
        Destroy(gameObject);
    }
}

