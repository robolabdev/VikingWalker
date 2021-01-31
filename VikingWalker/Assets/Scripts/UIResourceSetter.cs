using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIResourceSetter : MonoBehaviour
{
    [SerializeField] Resource currentResource;
    [SerializeField] Text text; 
    private void Update()
    {
        text.text = PlayerPrefs.GetInt(currentResource.ToString()).ToString();
    }
}
