using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public RandomGenerateAnimalPosition rand = new RandomGenerateAnimalPosition();
    public void RestartGameForGameWin()
    {
        SceneManager.LoadScene("BrightDay");
    }
}
