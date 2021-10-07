using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
   void step()
    {
        source.PlayOneShot(clip);
    }
}
