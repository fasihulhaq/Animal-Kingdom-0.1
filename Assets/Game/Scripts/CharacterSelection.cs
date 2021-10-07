﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;
    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");
        characterList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }
        if (characterList[index])
        {
            characterList[index].SetActive(true);
            if (CameraFollowPlayer.instance != null)
                CameraFollowPlayer.instance.target = characterList[index].transform.GetChild(characterList[index].transform.childCount - 1);
        }

        /*if (characterList[index])
        {
            characterList[index].SetActive(true);
            if(CameraFollowPlayer.instace != null)
                CameraFollowPlayer.instace.targetObject = characterList[index];
        }*/
    }

    public void ToggleLeft()
    {
        characterList[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }
        characterList[index].SetActive(true);
    }
    public void ToggleRight()
    {
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }
        characterList[index].SetActive(true);
    }
    public void BrightDay()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("BrightDay");
    }
}