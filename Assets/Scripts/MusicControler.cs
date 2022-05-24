using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControler : MonoBehaviour
{
    private bool _isEnabled = true;
    public AudioSource audioSource;

    private void UpdateState()
    {
        if (_isEnabled)
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
        _isEnabled = !_isEnabled;
        UpdateState();
    }
}
