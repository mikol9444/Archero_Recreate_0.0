using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager_Test : MonoBehaviour
{
    public static AudioManager_Test instance;
    public AudioClip loopClip;
    public AudioClip musicClip;
    public AudioClip ambientClip;
    public AudioClip oneShotClip;

    public bool isLoopOn = true;
    public bool isMusicOn = true;
    public bool isAmbientOn = true;


    private AudioSource loopSouce;
    private AudioSource musicSource;
    private AudioSource ambientSource;
    private AudioSource oneShotSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Create audio sources
        loopSouce = gameObject.AddComponent<AudioSource>();
        loopSouce.clip = loopClip;
        loopSouce.loop = true;

        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = musicClip;
        musicSource.loop = true;

        ambientSource = gameObject.AddComponent<AudioSource>();
        ambientSource.clip = ambientClip;
        ambientSource.loop = true;

        oneShotSource = gameObject.AddComponent<AudioSource>();
    }
    private void PlayLoop()
    {
        loopSouce.Play();
    }

    private void StopLoop()
    {
        loopSouce.Stop();
    }

    public void ToggleLoop()
    {
        isLoopOn = !isLoopOn;

        if (isLoopOn)
        {
            PlayLoop();
        }
        else
        {
            StopLoop();
        }
    }
    private void PlayMusic()
    {

        musicSource.Play();
    }

    private void StopMusic()
    {
        musicSource.Stop();
    }

    public void ToggleMusic()
    {
        isMusicOn = !isMusicOn;

        if (isMusicOn)
        {
            PlayMusic();
        }
        else
        {
            StopMusic();
        }
    }

    private void PlayAmbient()
    {
        ambientSource.Play();
    }

    private void StopAmbient()
    {
        ambientSource.Stop();
    }

    public void ToggleAmbient()
    {
        isAmbientOn = !isAmbientOn;

        if (isAmbientOn)
        {
            PlayAmbient();
        }
        else
        {
            StopAmbient();
        }
    }

    public void PlayOneShot()
    {
        oneShotSource.PlayOneShot(oneShotClip);
    }
}
