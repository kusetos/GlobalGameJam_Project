using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    private void Awake()
    {
        foreach(var sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.Clip;

            sound.source.loop = sound.Loop;
            sound.source.volume = sound.Volume;
            sound.source.pitch = sound.Pitch;
        }

    }

    private void Start()
    {
        //Play("Scream");
        //music theme

    }

    public void Play(string name)
    {
        Sound sound = Array.Find(sounds, s => s.Name == name);
        if (sound == null)
        {
            Debug.Log("Null refer");
        }
        else
        {
            if (!sound.source.isPlaying)
            {
                sound.source.Play();

            }
        }

    }
}
