using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        GetComponentInChildren<Animator>().SetFloat("Speed", GetComponent<CharacterController>().velocity.magnitude);
    }
}
