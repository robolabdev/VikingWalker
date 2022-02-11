using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum Resource
{
    wood,
    stone,
    gold,
    diamonds
}
public class CraftResource : MonoBehaviour
{
    
    [SerializeField] Resource currentZoneResource;
    [SerializeField, Range(1, 100)] float resourceValue = 100;
    [SerializeField] GameObject resourceMesh;
    public void MinusValue()
    {
        resourceValue--;
        if(resourceValue<0)
        {
            Destroy(resourceMesh);
            Destroy(gameObject);
        }
    }
    public void  AddPlayerScore()
    {
        int resource = PlayerPrefs.GetInt(currentZoneResource.ToString());
        resource++;
        PlayerPrefs.SetInt(currentZoneResource.ToString(), resource);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<Movement>())
        {
            if (Input.GetMouseButtonDown(0))
            {
                MinusValue();
                AddPlayerScore();
            }
        }
    }
}
