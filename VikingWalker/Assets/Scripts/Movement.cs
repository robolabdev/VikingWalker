using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement: MonoBehaviour
{
    [SerializeField] CharacterController playerController;

    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical") / 3;
        float h = Input.GetAxis("Horizontal") / 3;
        Vector3 direction = transform.forward * v + transform.right * h;
        playerController.SimpleMove(direction);
        Debug.Log("Current speed = " + playerController.velocity.magnitude);
    }
}

