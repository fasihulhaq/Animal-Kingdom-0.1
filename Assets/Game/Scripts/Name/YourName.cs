using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class YourName : MonoBehaviour
{
    public InputField fplayerName;

    private void Awake()
    {
        fplayerName.onValueChanged.AddListener(delegate { GetName(); });
    }

    public void GetName()
    {
        GameConstants.fPlayerName = fplayerName.text;
    }

  
}
