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
        float v = Input.GetAxis("Vertical")*2.5f;
        float h = Input.GetAxis("Horizontal")*2.5f;
        Vector3 dir = transform.forward * v + transform.right * h;
        playerController.SimpleMove(dir);
        Debug.Log("Current speed = " + playerController.velocity.magnitude);
    }
}
