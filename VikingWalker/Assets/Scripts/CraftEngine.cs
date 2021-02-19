using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftEngine : MonoBehaviour
{ 
    [SerializeField] string  currentCraftItem; 
    [SerializeField] GameObject itemToSpawn;
    [SerializeField,Range(10,1000)] int itemPrice =100; 
    public void SetCurrentCraftItem(string  settingitem)
    {
        int goldValue = PlayerPrefs.GetInt("gold");
        if(goldValue > itemPrice)
        { 
            currentCraftItem = settingitem;
            PlayerPrefs.SetString("CurrentCraftItem", currentCraftItem);
            goldValue = goldValue - itemPrice;
            PlayerPrefs.SetInt("gold", goldValue);
            CraftrHome();
        }  
    } 
    public void CraftrHome()
    {  
            GameObject item = Resources.Load<GameObject>(currentCraftItem);
            itemToSpawn = Instantiate(item);
            Vector3 playerPosition = GameObject.Find("Player").transform.position;
            itemToSpawn.transform.position = playerPosition;  
    }
      
}
