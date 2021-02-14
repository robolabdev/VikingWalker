using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject panel;
    [Range(1,100)] public int stonePrice = 15, woodPrice = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }

    public void SellResources(string resource)  
    {
        int goldValue = PlayerPrefs.GetInt("gold");
        int targetResourceValue = PlayerPrefs.GetInt(resource);

        int coast = 1;
        switch(resource)
        {
            case "wood":
            coast = woodPrice;
            break;
            case "stone":
            coast = stonePrice;
            break;
            default: 
            coast = 1;
            break;
        }


        goldValue = targetResourceValue * coast;
        targetResourceValue = 0 ;
        PlayerPrefs.SetInt(resource,targetResourceValue);
        PlayerPrefs.SetInt("gold",goldValue);

    }
}
