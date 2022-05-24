using Assets.Scripts;
using UnityEngine;

public class MapGenerater : MonoBehaviour
{
    public int Width;
    public int Height;

    public GameObject WalkTile;
    public GameObject WaterTile;

    public SpriteRenderer WalkRender => WalkTile.GetComponent<SpriteRenderer>();

    public void BoardSetup()
    {
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                var position = CoordinatesConverter.ConvertToScreenCoordinates(new Vector2(x, y));

                GameObject tile;
                if (y != 0 && Random.Range(0, 5) == 0)
                {
                    tile = Instantiate(WaterTile, position, Quaternion.identity);
                    tile.name = $"Tile water ({x}, {y})";
                }
                else
                {
                    tile = Instantiate(WalkTile, position, Quaternion.identity);
                    tile.name = $"Tile walk ({x}, {y})";

                    var control = tile.GetComponent<TileControl>();
                    control.X = x;
                    control.Y = y;
                }

                tile.transform.SetParent(GetComponent<Transform>());

                var render = tile.GetComponent<SpriteRenderer>();
                render.sortingOrder = Height - y;
            }
        }
    }

    void Start()
    {
        BoardSetup();
    }

    void Update()
    {
        
    }
}
