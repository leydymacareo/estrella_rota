using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar si se presiona la tecla Espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Mostrar el mensaje en la consola
            Debug.Log("Hola Mundo");
        }
    }
}
