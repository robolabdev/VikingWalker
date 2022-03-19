using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController playerController;
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void start()  
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 direction = transform.forward * v *speed + transform.right * h * speed;
        playerController.SimpleMove(direction);
        Debug.Log("Current speed = " + playerController.velocity.magnitude); 
    }
}
