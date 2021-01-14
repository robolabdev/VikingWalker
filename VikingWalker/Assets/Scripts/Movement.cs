using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move ment : MonoBehaviour
{

    
    // Start is called before the first frame update
    void start  
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(v, 0, h);
    }
}
