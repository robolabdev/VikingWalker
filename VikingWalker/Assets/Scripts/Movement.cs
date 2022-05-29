using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] CharacterController _characterControllerInstance;
    [SerializeField,Range(1,10)] float _speedOfCharacter;
    // Start is called before the first frame update
    void Start ()
    {
        _speedOfCharacter = 5;
        _characterControllerInstance = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * _speedOfCharacter;
        float h = Input.GetAxis("Horizontal");
        Vector3 direction = transform.forward * v;
        transform.Rotate(0, h, 0);
        _characterControllerInstance.SimpleMove(direction);
    }
}
