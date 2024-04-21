using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject startPoint; // Ponto inicial (o ponto de cima) clique da esquerda
    public GameObject endPoint; // Ponto final (o ponto de baixo) clique da direita
    public float moveDuration = 1f; // Duração do movimento

    public float speed = 5f; // Velocidade de movimento
    public float gravity = 8;


    public float TempoParaCair = 2;
    private float TempoParaCairCurrent;
    private bool PodePular = true;




    // Estado atual do movimento
    private bool isMoving = false;

    // Inicia o movimento para o ponto final
    public void MoveToEndPoint() 
    {
        if (!isMoving)
        {
            StartCoroutine(MoveToPoint(endPoint.transform.position));
            PodePular = true;
            endPoint.GetComponent<Collider>().enabled = true;
        }
    }

    // Inicia o movimento para o ponto inicial
    public void MoveToStartPoint()
    {
        if (!isMoving && PodePular == true)
        {
            StartCoroutine(MoveToPoint(startPoint.transform.position));
            PodePular = false;
            TempoParaCairCurrent = TempoParaCair; // essa linha so pode ser chamada quando destruir alguma nota ou pisar no chao
            startPoint.GetComponent<Collider>().enabled = true;
        }
    }

    // Movimento suave entre pontos
    private IEnumerator MoveToPoint(Vector3 targetPosition)
    {
        isMoving = true;
        float elapsedTime = 0f;
        Vector3 startPosition = transform.position;

        while (elapsedTime < moveDuration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
        isMoving = false;
    }

    // Verifica entrada do jogador
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width / 2) //clique da direita
                {
                    MoveToStartPoint();
                    
                }
                else //clique da esquerda
                {
                    MoveToEndPoint();
                    
                }
                
            }
        }

        // Movimento para frente ao longo do eixo X
        transform.Translate(Vector3.right * speed * Time.deltaTime);


        // Gravidade
        if (transform.position.y > 0 && TempoParaCairCurrent <= 0)
        
        transform.Translate(Vector3.down * gravity * Time.deltaTime);
            
        

        TempoParaCairCurrent -= Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("chao"))
        {
            PodePular = true;
        }
    }
}
