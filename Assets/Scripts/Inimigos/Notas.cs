using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : Inimigo
{
    GameManager gm;
    
    void Start() 
    {
        gm = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            gm.AddScore(10);
            Destroy(this.gameObject);
        }

    }
    void Update()
    {
        if (gm.score >= 40 && gm != null)
        {
            gm.Vitoria();
        }
    }
}