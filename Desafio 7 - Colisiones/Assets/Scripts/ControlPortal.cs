using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPortal : MonoBehaviour
{
    [SerializeField]
    bool Achicado = true;
    private void OnTriggerEnter(Collider other)
    {
        if (Achicado == false)
        {
            other.transform.localScale = other.transform.localScale * 2;
        }
        else
        {
            other.transform.localScale = other.transform.localScale;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (Achicado)
        {
            other.transform.localScale = other.transform.localScale / 2;
            Achicado = false;
        }
        else
        {
            other.transform.localScale = other.transform.localScale;
            Achicado = true;
        }
    }
}
