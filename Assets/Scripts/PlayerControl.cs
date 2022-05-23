using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{
    private bool _isMoving = false;

    public void Move(int xGame, int yGame)
    {
        Move(new Vector2(xGame, yGame));
    }

    public void Move(Vector2 gameCoordinates)
    {
        if (_isMoving)
            return;

        Vector2 screenCoordTile = CoordinatesConverter.ConvertToScreenCoordinates(gameCoordinates);

        Vector2 screenTile = new Vector2(screenCoordTile.x, screenCoordTile.y + 0.8f);
        StartCoroutine(SmoothMoving(screenTile));
    }

    private IEnumerator SmoothMoving(Vector2 newPostion)
    {
        _isMoving = true;
        var animator = gameObject.GetComponent<Animator>();
        animator.SetBool("Walk", true);

        var oldPosition = gameObject.transform.position;

        for (float i = 0.1f; i <= 1; i += 0.05f)
        {
            gameObject.transform.position = Vector2.Lerp(oldPosition, newPostion, i);
            yield return new WaitForSeconds(0.1f);
        }
        gameObject.transform.position = newPostion;

        animator.SetBool("Walk", false);
        animator.SetTrigger("Attack");
        _isMoving = false;
    }
}
