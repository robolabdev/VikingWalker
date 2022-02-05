using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Text woodcraft;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        woodcraft.text = PlayerPrefs.GetInt("wood").ToString();
    }
}
