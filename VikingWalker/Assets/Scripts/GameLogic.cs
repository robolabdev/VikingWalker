using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public Text woodCraft;

    void update()
    {
        woodCraft.text = PlayerPrefs.GetInt("wood").ToString();
    }
}
