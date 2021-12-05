using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    
    void Update()
    {
        float currentSpeed = GetComponentInParent<CharacterController>().velocity.magnitude;
        GetComponent<Animator>().SetFloat("Speed", currentSpeed);
        float random = Mathf.Sin(Time.time);
        GetComponent<Animator>().SetFloat("Randomizer", random);
    }
}
