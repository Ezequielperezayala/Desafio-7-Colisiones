using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    [SerializeField]
    bool Achicado = true;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Entrando en Colision con -->" + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        if (Achicado)
        {
            Achicado = false;
            transform.localScale = transform.localScale / 2;
        }
        else if (Achicado == false)
        {
            Invoke("delayPortal", 0.1f);
            
            
        }

    }

    void delayPortal()
    {
        Achicado = true;
        transform.localScale = transform.localScale * 2;
    }

  
}
