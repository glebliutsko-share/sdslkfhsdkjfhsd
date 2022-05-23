using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileControl : MonoBehaviour
{
    private GameObject _player;

    private void OnMouseUp()
    {
        _player.transform.position = transform.position;
    }

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
    }
}
