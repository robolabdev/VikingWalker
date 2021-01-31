using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WORLDBORDER : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        SceneManager.LoadScene("mathew");
    }
    // Update is called once per frame
  
}
