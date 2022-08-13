using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTeletransporte : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10)]
    int Cooldown = 2;

    float TimeTeleport = 0f;

    [SerializeField]
    Transform TeletransportarA;

    private void OnCollisionEnter(Collision Other)
    {
        TimeTeleport = 0f;
    }

    private void OnCollisionStay(Collision Other)
    {
        TimeTeleport += Time.deltaTime;
        if (TimeTeleport >= Cooldown)
        {
            Other.transform.position = TeletransportarA.position;
            transform.Rotate(new Vector3(0, 0, 45));
        }
    }
}
