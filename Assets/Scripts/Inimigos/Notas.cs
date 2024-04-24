using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : Inimigo
{
    GameManager gm;
    public GameObject explosion;

    public int vida;

    public void TomarDano(int quantidade)
    {
        vida -= quantidade;
        if (vida <= 0)
        {
            Morre();

        }
    }

    public virtual void Morre()
    {
        Destroy(gameObject);
    }

    void Start() 
    {
        gm = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hitbox")
        {
 
                    gm.AddScore(10);
                    Vector3 position = transform.position;
                    position.z = -1f;
                    explosion.transform.position = position;

                    explosion.SetActive(true);
                    TomarDano(1);

        }

        

    }
    void Update()
    {

    }
}