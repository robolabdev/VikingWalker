using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController playerController;
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    
    // Start is called before the first frame updat  }

    // Update is called once per frame
    void Update()
    {
        float d = 0;
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        Vector3 direction = transform.forward * v + transform.right * h;
        
        transform.position = transform.position + new Vector3(v, d, h);
        playerController.SimpleMove(direction);
        Debug.Log("Current speed = " + playerController.velocity.magnitude);

    }
}
