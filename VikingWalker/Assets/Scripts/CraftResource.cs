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
}
public GameObject resourceObject;
[SerializeField, Range(1 - 100)]float resourceValue = 100;
public void MinuesValue()
{
    resourceValue = resourceValue - 1;
    if (resourceValue < 0)
        Destroy(resourceObject);
    Destroy(gameObject);
}