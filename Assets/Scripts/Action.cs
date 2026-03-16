using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Ejemplo: número generado aleatoriamente entre 0 y 3
    int numeroGenerado = Random.Range(0, 4);
    uiManager.SimulateAnswerClick(numeroGenerado);
}
