using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftEngine : MonoBehaviour
{
 

    [SerializeField] string  currentCraftItem;
    [SerializeField] bool isItemSelected =false; 
    [SerializeField] GameObject spawnedItem;
    [SerializeField,Range(10,1000)] int homePrice =100;

    public void SetCurrentCraftItem(string  settingitem)
    {
        int goldValue = PlayerPrefs.GetInt("gold");
        if(goldValue > homePrice)
        {
            isItemSelected = true;
            currentCraftItem = settingitem;
            PlayerPrefs.SetString("CurrentCraftItem", currentCraftItem);
            goldValue = goldValue - homePrice;
            PlayerPrefs.SetInt("gold", goldValue);
        }
       
    }


    public void CraftrHome()
    {

        

        if(isItemSelected )
        {
            GameObject item = Resources.Load<GameObject>(currentCraftItem);
            spawnedItem = Instantiate(item);
            Vector3 playerPosition = GameObject.Find("Player").transform.position;
            spawnedItem.transform.position = playerPosition; 
            isItemSelected = false;

           


        }

        
         
        
    }


    private void Update()
    {
        CraftrHome();
    }
}
