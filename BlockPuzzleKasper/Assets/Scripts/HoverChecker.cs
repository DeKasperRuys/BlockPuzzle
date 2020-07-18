using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverChecker : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer rend;

    public Sprite spriteWood;
    public Sprite spriteTile;

    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "block")
        {          
            spriteRenderer.sprite = spriteWood;
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.sprite = spriteTile;
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    }
}
