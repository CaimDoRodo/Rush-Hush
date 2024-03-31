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
    
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddScore(int points)
    {
        score += points;
        pontos.text = ("Score: " + score);
    }

    public void GameOver()
    {

        painel.SetActive(true);
        Time.timeScale  = 0f;
    } 
    
    public void Vitoria()
    {

        painel_vit.SetActive(true);
        Time.timeScale  = 0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Blocagem");
        
    }
}
