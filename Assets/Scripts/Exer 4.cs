using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer4 : MonoBehaviour
{
    [SerializeField] int pontuacao = 0;
    void Start()
    {
        for(int combo = 1 ; combo <= 7; combo++)
        {
            pontuacao += 10;
        }

        print("Pontuação total: ");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
