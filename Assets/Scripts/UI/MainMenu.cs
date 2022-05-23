using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject LevelsMenu;

    public void OpenLevelsMenu()
    {
        gameObject.SetActive(false);
        LevelsMenu.SetActive(true);
    }
}
