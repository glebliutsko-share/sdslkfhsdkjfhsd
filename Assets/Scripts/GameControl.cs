using UnityEngine;

public class GameControl : MonoBehaviour
{
    private bool _isStartGame = false;
    private GameObject _player;
    private GameObject _map;

    public GameObject MapPrefab;
    public GameObject PlayerPrefab;

    public GameObject MainMenu;
    public GameObject LevelsMenu;

    private void CloseAllMenu()
    {
        MainMenu.SetActive(false);
        LevelsMenu.SetActive(false);
    }

    public void OpenMainMenu()
    {
        CloseAllMenu();
        MainMenu.SetActive(true);
    }

    public void OpenLevelsMenu()
    {
        CloseAllMenu();
        LevelsMenu.SetActive(true);
    }

    public void StartLevel(int level)
    {
        if (_isStartGame)
            return;

        CloseAllMenu();

        _player = Instantiate(PlayerPrefab);
        _player.transform.SetParent(gameObject.transform);
        _player.name = "PlayerElf";
        _player.GetComponent<PlayerControl>().Move(level, 0, false);

        _map = Instantiate(MapPrefab);
        _map.transform.SetParent(gameObject.transform);
        _map.name = "Map";
    }
}
