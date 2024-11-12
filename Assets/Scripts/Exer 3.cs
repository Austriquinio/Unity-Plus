using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int totalMoedas;

    // Start is called before the first frame update
    void Start()
    {
        for(int fase = 0; fase < 10; fase++)
        {
            totalMoedas += 3;

            print("O total de moedas");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
