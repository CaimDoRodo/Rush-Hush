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

    public void removerVida(int quantidade)
    {
        vida += quantidade;
        textMeshPro.text = "Vida: " + vida;
    }

    public void adicionarVida(int quantidade)
    {
        vida -= quantidade;
        textMeshPro.text = "Vida: " + vida;
    }
    
}
