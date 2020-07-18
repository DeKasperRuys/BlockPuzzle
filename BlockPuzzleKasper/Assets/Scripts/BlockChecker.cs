using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockChecker : BlockDragger
{
   
  private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Tile" && isDragged == false)
        {
            transform.position = collision.gameObject.transform.position;
            isLocked = true;
            //collision.gameObject.tag = "LockedTile";
        }

    }
   
}
