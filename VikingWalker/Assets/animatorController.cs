using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorController : MonoBehaviour
{
    

    void Update()
    {
        float speed = GetComponent<CharacterController>().velocity.magnitude;

        GetComponentInChildren<Animator>().SetFloat("IdleToWalk", speed);
    }
}
