using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public static class CoordinatesConverter
    {
        public static Vector2 ConvertToScreenCoordinates(Vector2 gameCoordinates)
        {
            float xScreen = gameCoordinates.y % 2 == 0 ? gameCoordinates.x + 0.5f : gameCoordinates.x;
            float yScreen = gameCoordinates.y - gameCoordinates.y * 0.2f;

            return new Vector2(xScreen, yScreen);
        }
    }
}
