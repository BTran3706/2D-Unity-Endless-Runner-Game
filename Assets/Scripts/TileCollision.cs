using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCollision : MonoBehaviour
{

    private string[] color = new string[] 
    { 
        "Red", "Green", "Blue" 
    };

    private int colorSize = 2;
    private int colorIndex;
    private string currentColor = "Red";
   
    public Collider2D tile;
    public Collider2D player;

    void Update()
    {
        changeColor();
        checkColor(player);
    }

    void changeColor()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            colorIndex++;
            if (colorIndex > colorSize)
            {
                colorIndex = 0;
            }
            currentColor = color[colorIndex];
        }
    }

    void checkColor(Collider2D player)
    {
        if (player.IsTouching(tile) && tile.gameObject.tag != currentColor)
        {
            player.isTrigger = true;
        }
    }

}
