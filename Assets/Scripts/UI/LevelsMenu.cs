using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsMenu : MonoBehaviour
{
    public GameObject PreviousMenu;

    public void OpenPreviousMenu()
    {
        PreviousMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
