using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    
    // Start is called before the first frame updat  }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical")/5;
        float h = Input.GetAxis("Horizontal")/5;
        transform.position = transform.position + new Vector3(v, 0, h);

    }
}
