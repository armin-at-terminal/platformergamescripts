using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    // speed boost multiplier (base speed * speedFactor)
    public float speedFactor = 25f;

    //speed up when standing on a speed booster
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    // slow back down after exiting
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
