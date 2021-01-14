using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Movement : MonoBehaviour
{

    [SerializeField] CharacterController playerController;
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
        Vector3 direction = transform.forward * v + transform.right * h;
        playerController.SimpleMove(direction*4);
        Debug.Log("Current speed =" + playerController.velocity.magnitude);
 
 
        float v = Input.GetAxis("Vertical") / 3;
        float h = Input.GetAxis("Horizontal") / 3;

        transform.position = transform.position + new Vector3(h, 0, v); 
 
    }
}
