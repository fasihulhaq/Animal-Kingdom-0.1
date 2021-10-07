using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Start()
    {
        //int y = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(Splash(3f));
        //if (y > 1)
        //{
        //    StopAllCoroutines();
        //}
    }
    IEnumerator Splash(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainManu");

        Debug.Log("in coroutine");
        
    }
}
