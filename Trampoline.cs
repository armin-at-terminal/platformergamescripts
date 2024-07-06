using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    float jumpBoost = 5f;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpBoost;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpBoost;
    }
}
