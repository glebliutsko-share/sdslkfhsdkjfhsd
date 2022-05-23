using UnityEngine;

public class TileControl : MonoBehaviour
{
    private GameObject _player;

    public int X { get; set; }
    public int Y { get; set; }

    private void OnMouseUp()
    {
        var control = _player.GetComponent<PlayerControl>();
        control.Move(X, Y);
    }

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
    }
}
