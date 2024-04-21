using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosions : MonoBehaviour
{
    public float startSize = 1f;           // Tamanho inicial do objeto
    public float endSize = 0f;             // Tamanho final do objeto
    public float fadeDuration = 3f;        // Duração da transição de transparência e tamanho

    private SpriteRenderer spriteRenderer;
    private float startTime;
    private bool isFading = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (isFading)
        {
            float t = (Time.time - startTime) / fadeDuration;
            Color color = spriteRenderer.color;
            color.a = Mathf.Lerp(1f, 0f, t);
            spriteRenderer.color = color;

            transform.localScale = Vector3.one * Mathf.Lerp(startSize, endSize, t);

            if (t >= 1f)
            {
                isFading = false;
                gameObject.SetActive(false);
            }
        }
    }

    private void OnEnable()
    {
        transform.localScale = Vector3.one * startSize;
        isFading = true;
        startTime = Time.time;
    }
}


