using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerateAnimalPosition : MonoBehaviour
{
    void Start()
    {
        postionChange();
    }

    public void postionChange()
    {
        float xRange = Random.Range(28f, 48f);
        float zRange = Random.Range(37f, 54f);
        transform.position = new Vector3(xRange, transform.position.y, zRange);
    }
}
