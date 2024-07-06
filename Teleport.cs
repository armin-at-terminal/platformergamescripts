using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    // ma ei saanud sellest seletusest mitte midagi aru ja ma improviseerisin
    public Transform teleportPoint;
    private void OnTriggerEnter(Collider other)
    {
        // muudan rotationi ja positsiooni samaks mis teleportpoint
        other.transform.position = teleportPoint.position;
        other.transform.rotation = teleportPoint.rotation;
    }
}
