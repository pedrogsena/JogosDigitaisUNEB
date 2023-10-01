using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection2DCollor : MonoBehaviour
{
    public Color collisionColor = Color.red;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colisão detectada com o objeto:" + collision.gameObject.name);
        ChangeColor();
    }

    private void ChangeColor()
    {
        if (spriteRenderer != null)
            spriteRenderer.color = collisionColor;
        
    }
}