using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public Text woodCraft;

    private void Update()
    {
        woodCraft.text = PlayerPrefs.GetInt("wood").ToString();
    }
}
