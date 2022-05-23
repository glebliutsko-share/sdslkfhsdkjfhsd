using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject MapGenerater;
    public GameObject Player;

    void Awake()
    {
        Instantiate(MapGenerater);
    }
}
