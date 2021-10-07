using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneForAllPages : MonoBehaviour
{
    AudioSource muteAudio;
    public bool muted;
    public bool checkMute=true;

    public void Start()
    {
        muteAudio=GetComponent<AudioSource>();
    }
    public void ChangeSelectEpisode()
    {
        SceneManager.LoadScene("EpisodeSelect");
    }
    public void MainManu()
    {
        SceneManager.LoadScene("MainManu");
    }
    public void PlayerSelection()
    {
        SceneManager.LoadScene("PlayerSelection");
    }
    public void GamePlay()
    {
        SceneManager.LoadScene("BrightDay");
    }
    public void PauseGame()
    {
        SceneManager.LoadScene("Paused");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void MuteAudio()
    {
        if (!muteAudio.mute)
        {
            SetAudioMute(true);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void SetAudioMute(bool mute)
    {
        AudioSource[] sources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        for (int index = 0; index < sources.Length; ++index)
        {
            sources[index].mute = mute;
        }
        muted = mute;
    }


}
