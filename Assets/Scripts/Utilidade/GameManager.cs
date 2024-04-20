using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;



public class GameManager : MonoBehaviour
{
    public Text text_Final;
    [SerializeField] GameObject painel;
    [SerializeField] GameObject painel_vit;

    public int score = 0;
    public Text pontos;

    public HealthController HP_Controller;

    private float tempoDecorrido = 0f;
    public Text cronometro;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        tempoDecorrido += Time.deltaTime;
        AtualizarCronometro();
    }

    void AtualizarCronometro()
    {
        int minutos = Mathf.FloorToInt(tempoDecorrido / 60f);
        int segundos = Mathf.FloorToInt(tempoDecorrido % 60f);
        
        cronometro.text = string.Format("Tempo: {0:00}:{1:00}", minutos, segundos);
    }

    public void AddScore(int points)
    {
        score += points;
        pontos.text = ("Score: " + score);
    }

    public void GameOver()
    {
        painel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Vitoria()
    {
        painel_vit.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Blocagem");
    }
}
