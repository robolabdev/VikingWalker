using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] CharacterController cc;
    [SerializeField,Range(1,20)]private float  speed = 7 ;

    // Start is called before the first frame update
    void Start ()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 direction = transform.forward * v;
        cc.SimpleMove(direction * speed);
        transform.Rotate(0, h * speed, 0);
    }
}
