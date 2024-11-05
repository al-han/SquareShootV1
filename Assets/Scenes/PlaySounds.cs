using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is suppose to add some sounds but i was unable to do it
public class GameAudio1 : MonoBehaviour
{

    public AudioSource audioSource;


    public AudioClip sfx1;


    public void PlayThisSound()
    {
        audioSource.PlayOneShot(sfx1);
    }

}