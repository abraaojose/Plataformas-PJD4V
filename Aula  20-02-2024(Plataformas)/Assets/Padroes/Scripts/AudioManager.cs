using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private float volume = 1f;

    public static AudioManager Instance;

    private void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
       
    }

    private void OnEnable()
    {
        AudioObserverManager.OnVolumeChanged += ProcessVolumeChanged;
    }
    private void ProcessVolumeChanged(float value)
    {
        volume = value;   
    }

    private void OnDisable()
    {
        AudioObserverManager.OnVolumeChanged -= ProcessVolumeChanged;
    }

}
