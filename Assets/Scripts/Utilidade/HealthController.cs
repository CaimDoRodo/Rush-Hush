using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    public float VidaMaxima = 30;
    public float vida = 30;
    public TextMeshProUGUI textMeshPro;
    private GameManager gm;

    void Start()
    {
        vida = VidaMaxima;
        textMeshPro.text = "Vida: " + vida;

        gm = FindObjectOfType<GameManager>();

    }

    public void modificarVida(int quantidade)
    {
        vida += quantidade;

        if (vida >= VidaMaxima) vida = VidaMaxima;

        textMeshPro.text = "Vida: " + vida;


    }

    void Update()
    {
        if (vida <= 0 && gm != null)
        {
            gm.GameOver();
        }
    }
}
