using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bau : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(FindObjectOfType<GameManager>().possuiChave == true)
            {
                Debug.Log("O baú foi aberto");
            }
            else
            {
                Debug.Log("Você precisa de uma Chave");
            }
        }
    }
}
