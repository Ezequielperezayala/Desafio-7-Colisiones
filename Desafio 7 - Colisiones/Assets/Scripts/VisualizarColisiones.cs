using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizarColisiones : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision Other)
    {
        Debug.Log("Entrando en contacto con -->" + Other.gameObject.name);
    }
}
