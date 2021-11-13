using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Movement: MonoBehaviour
{
    [SerializeField] CharacterController playerController;
    public float playerHeightJump = 5f;
    public Transform playerX;
    public Transform playerZ;
     
=======
public class Movement : MonoBehaviour
{
    public float Speed = 50;
    [SerializeField] CharacterController playerController;
    // Start is called before the first frame update
>>>>>>> 46e286e5407b4f17a809495f4e4fb2f52300df56
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical") / 3;
        float h = Input.GetAxis("Horizontal") / 3;
<<<<<<< HEAD
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
=======
        Vector3 direction = transform.forward * v + transform.right * h;
        playerController.SimpleMove(direction*Speed);
        Debug.Log("Current Speed = " + playerController.velocity.magnitude);
>>>>>>> 46e286e5407b4f17a809495f4e4fb2f52300df56
    }
}

