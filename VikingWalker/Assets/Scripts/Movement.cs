using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") / 3;
        float h = Input.GetAxis("Horizontal") / 3;
       Vector3 direction = transform.forward * v + transform.right * v;
        playerController.SimpleMove(direction);
        Debug.Log("Current speed = " + playerController.velocity.magnitude);
    }
}
