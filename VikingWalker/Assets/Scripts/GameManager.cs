using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shopPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Tab))
        {
            shopPanel.SetActive(true);
        }
       if(Input.GetKeyUp(KeyCode.Tab))
        {
            shopPanel.SetActive(false);
        }

    }
    public void SelfResource(string resourceToSell)
    {

        int goldValue = PlayerPrefs.GetInt("gold");
        int resourceToSellValue = PlayerPrefs.GetInt(resourceToSell);
        switch(resourceToSell)
        {
            case "wood":
                goldValue += resourceToSellValue * woodprice;
                break;
            case "stone":
                goldValue += resourceToSellValue * stoneprice;
                break;
            default:
                goldValue += resourceToSellValue;
                break;
        }
        resourceToSellValue = 0;
        PlayerPrefs.SetInt("gold", goldValue);
        PlayerPrefs.SetInt(resourceToSell, 0);
    }
    public int stoneprice = 5;
    public int woodprice = 2;
    
}
