using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour
{
    public bool IsEnabled = true;
    public AudioSource audioSource;

    private void UpdateState()
    {
        if (IsEnabled)
            audioSource.Play();
        else
            audioSource.Pause();
    }

    private void Awake()
    {
        UpdateState();
    }

    public void Switch()
    {
        IsEnabled = !IsEnabled;
        UpdateState();
    }
}
