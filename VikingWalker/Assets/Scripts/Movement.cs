using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement: MonoBehaviour
{
    [SerializeField] CharacterController playerController;
    public float playerHeightJump = 5f;
    public Transform playerX;
    public Transform playerZ;
     
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical") / 3;
        float h = Input.GetAxis("Horizontal") / 3;
        float z = Input.GetAxis("Jump") / 3;
        Vector3 direction = transform.forward * v + transform.right * h;
        Vector3 jump = transform.up * z + transform.up;
        playerController.SimpleMove(jump);
        playerController.SimpleMove(direction);
        Debug.Log("Current speed = " + playerController.velocity.magnitude);          
    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(playerX, playerHeightJump, playerZ);
        }
    }
}

