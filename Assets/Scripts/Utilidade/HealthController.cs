using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    public float VidaMaxima = 100;
    public float vida;
    public TextMeshProUGUI textMeshPro;

    void Start()
    {
        vida = VidaMaxima;
        textMeshPro.text = "Vida: " + vida;
    }

    public void modificarVida(int quantidade)
    {
        vida += quantidade;

        if (vida >= VidaMaxima) vida = VidaMaxima;

        textMeshPro.text = "Vida: " + vida;

        if (vida <= 0)
        {
            Debug.Log("TELA DE DERROTA!"); //tela de derrota aqui?
            vida = 0;
        }
    }
    
}
