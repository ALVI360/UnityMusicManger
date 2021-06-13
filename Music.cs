using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Music
{

    public string name; // Music Name
    public bool loop;
    public MusicLayer[] layers;
}

[System.Serializable]
public class MusicLayer {

    public string name; // Layer name
    public AudioClip song;
    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
