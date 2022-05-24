using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControler : MonoBehaviour
{
    private bool _isEnableSound = true;
    public AudioClip AudioClick;

    public void PlayClick()
    {
        if (!_isEnableSound)
            return;

        GetComponent<AudioSource>().PlayOneShot(AudioClick);
    }

    public void Switch() => 
        _isEnableSound = !_isEnableSound;
}
