using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftEngine : MonoBehaviour
{
    public void CraftItem ()
    {
        GameObject item = Resources.Load<GameObject>(currentCraftItem);
        itemToSpam = Instantiate(item);
        Vector3 playerPosition = GameObject.Find("Player").transform.position;
        itemToSpam.transform.position = playerPosition;
    }
    // Start is called before the first frame update
    [SerializeField] string currentCraftItem;
    [SerializeField] GameObject itemToSpam;
    [SerializeField, Range(10, 1000)] int itemPrice = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCurrentCraftItem(string settingitem)
    {
        int goldValue = PlayerPrefs.GetInt("gold");
        if (goldValue > itemPrice)
        {
            currentCraftItem = settingitem;
            PlayerPrefs.SetString("currentCraftItem", currentCraftItem);
            goldValue = goldValue - itemPrice;
            PlayerPrefs.SetInt("gold", goldValue);
            CraftItem();
        }
    }
}
