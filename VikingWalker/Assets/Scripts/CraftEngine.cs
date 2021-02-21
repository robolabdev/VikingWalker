using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftEngine : MonoBehaviour
{
    [SerializeField]string currentCraftItem;
    [SerializeField] GameObject itemToSpawn;
    [SerializeField, Range(10, 1000)] int itemPrice = 100;

    public void CraftHome()
    {
        GameObject item = Resources.Load<GameObject>(currentCraftItem);
        itemToSpawn = Instantiate(item);
        Vector3 playerPos = GameObject.Find("Player").transform.position;
        itemToSpawn.transform.position = playerPos;
    }

    public void SetCurrentCraftItem(string settingItem)
    {
        int goldValue = PlayerPrefs.GetInt("gold");

        if (goldValue > itemPrice)
        {
            currentCraftItem = settingItem;
            PlayerPrefs.SetString("currentCraftItem", currentCraftItem);
            goldValue = goldValue - itemPrice;
            PlayerPrefs.SetInt("gold", goldValue);
            CraftHome();
        }
    }
}

