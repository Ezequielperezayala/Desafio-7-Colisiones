using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovientoPlayer : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)]
    float Speed;

    float RotationX = 0f;

    float movimientoX;
    float movimientoZ;
    void Update()
    {
        RotationCamera();
        Movientohorizontal();
        MovientoForward();
    }

    void RotationCamera()
    {
        RotationX += Input.GetAxis("Mouse X");
        Quaternion NewRotation = Quaternion.Euler(0, RotationX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, NewRotation, 6f * Time.deltaTime);
    }

    void Movientohorizontal()
    {
        movimientoX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        transform.Translate(movimientoX, 0, 0);
    }

    void MovientoForward()
    {
        movimientoZ = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        transform.Translate(0, 0, movimientoZ);
    }
}