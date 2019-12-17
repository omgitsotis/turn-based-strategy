using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    private SpriteRenderer render;
    public Sprite[] sprites;

    public float hoverAmount;

    public LayerMask obstacleLayer;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        // Select on of the sprite tiles at random on start
        int randTile = Random.Range(0, sprites.Length);
        render.sprite = sprites[randTile];

    }

    private void OnMouseEnter() => transform.localScale += Vector3.one * hoverAmount;

    private void OnMouseExit() => transform.localScale -= Vector3.one * hoverAmount;

    public bool IsClear()
    {
        Collider2D obstacle = Physics2D.OverlapCircle(transform.position, 0.2f, obstacleLayer);
        if (obstacle == null)
        {
            return true;
        }

        return false;
    }
}
