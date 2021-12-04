using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftResource : MonoBehaviour
{
    enum Resource
    {
        wood,
        steel,
        gold,
        diamonds
    };
    [SerializeField] Resource currentZoneResource;

    public GameObject resourceObject;

    [SerializeField, Range(1, 100)] float resourceValue = 100;

    public void MinusValue()
    {
        resourceValue = resourceValue - 1;
        if (resourceValue < 0)
            Destroy(resourceObject);
    }

    public void AddPlayerScore()
    {
        int playerResource = PlayerPrefs.GetInt(currentZoneResource.ToString());
        playerResource = playerResource + 1;
        PlayerPrefs.SetInt(currentZoneResource.ToString(), playerResource);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<Movement>())
        {
            if(Input.GetMouseButtonDown(0))
            {
                MinusValue();
                AddPlayerScore();
            }
        }
    }
}
