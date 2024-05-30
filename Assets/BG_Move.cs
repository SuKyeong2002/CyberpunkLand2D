using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Move : MonoBehaviour
{

    public Transform player;
    public SpriteRenderer spriteBG;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.position;

        spriteBG.material.mainTextureOffset = new Vector2(player.position.x, player.position.y) * 0.01f;
    }
}
