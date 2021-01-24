using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = GetComponentInParent<CharacterController>().velocity ;
        GetComponent<Animator>().SetFloat("Speed", currentSpeed);
        float random = Mathf.Sin(Time.time);
        GetComponent<Animator>().SetFloat("", random); 
    }
}
