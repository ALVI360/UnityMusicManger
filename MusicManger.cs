using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MusicManger : MonoBehaviour
{

    public Music[] music;

    public static MusicManger instance;


    void Awake()
    {
        if (instance == null)
        {
            
        }

        DontDestroyOnLoad(gameObject);  


        foreach (Music m in music)
        {

            // m.source.loop = m.loop;
            foreach (MusicLayer ml in m.layers)
            {
                ml.source = gameObject.AddComponent<AudioSource>();
                // ml.source = ml.name;
                ml.source.clip = ml.song;
                ml.source.volume = ml.volume;
                ml.source.pitch = ml.pitch;
            }

        }
    }

    public void PlayMusic(string name)
    {

        Music m = Array.Find(music, music => music.name == name);
        if (m == null)
        {
            Debug.Log("music with name " + name + "was not found to play");
            return;
        }

        foreach (MusicLayer ml in m.layers)
        {

            ml.source.Play();

        }
    }

    public void MuteMusic(string name)
    {

        Music m = Array.Find(music, music => music.name == name);
        if (m == null)
        {
            Debug.Log("music with name " + name + "was not found to play");
            return;
        }

        foreach (MusicLayer ml in m.layers)
        {

            ml.source.mute = true;

        }

    }

    public void MuteLayer(string name, int num)
    {

        Music m = Array.Find(music, music => music.name == name);
        if (m == null)
        {
            Debug.Log("music with name " + name + "was not found to play");
            return;
        }

        int counter = 0;
        foreach (MusicLayer ml in m.layers)
        {
            if (counter == num)
            {
                ml.source.mute = true;
            }

            counter++;
        }

    }

    public void UnMuteLayer(string name, int num)
    {

        Music m = Array.Find(music, music => music.name == name);
        if (m == null)
        {
            Debug.Log("music with name " + name + "was not found to play");
            return;
        }

        int counter = 0;
        foreach (MusicLayer ml in m.layers)
        {
            if (counter == num)
            {
                ml.source.mute = false;
            }

            counter++;
        }

    }

    public void UnMuteMusic(string name)
    {

        Music m = Array.Find(music, music => music.name == name);
        if (m == null)
        {
            Debug.Log("music with name " + name + "was not found to play");
            return;
        }

        foreach (MusicLayer ml in m.layers)
        {

            ml.source.mute = false;

        }

    }



}
