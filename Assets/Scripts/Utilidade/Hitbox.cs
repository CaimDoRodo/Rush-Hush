using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public float disableTime = 0.25f; // Tempo em segundos antes de desativar o collider

    private Collider collider;
    private float timer;

    private void Start()
    {
        collider = GetComponent<Collider>();
        timer = 0f;
    }

    private void Update()
    {
        // Verifica se o collider está ativado e inicia o temporizador
        if (collider.enabled)
        {
            timer += Time.deltaTime;
            // Desativa o collider após o tempo definido
            if (timer >= disableTime)
            {
                collider.enabled = false;
            }
        }
        else
        {
            // Reinicia o temporizador se o collider for desativado por outra razão
            timer = 0f;
        }
    }
}
