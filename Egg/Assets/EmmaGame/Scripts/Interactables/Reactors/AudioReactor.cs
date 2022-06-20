using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioReactor : StateReactor
{
    public AudioClip active;
    public AudioClip inactive;
    AudioSource sound;

    protected override void Awake()
    {
        base.Awake();
        sound = GetComponent<AudioSource>();
        
    }

    public override void React()
    {
        if (switcher.state)
        {
            sound.clip = active;
            sound.Play();
        }
        else
        {
            sound.clip = inactive;
            sound.Play();
        }
    }
}