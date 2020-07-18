using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDragger : MonoBehaviour
{
    private float xStartPos;
    private float yStartPos;
    private Vector3 startPos;

    public bool isDragged = false;


    public bool isLocked = false;


    private void Start()
    {
        startPos = transform.position;
        

    }
    // Update is called once per frame
    void Update()
    {
        if (isDragged == true && isLocked == false)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 1);
        }
        else
        {
            //transform.position = startPos;
            
        }
        
       
    }
  

    private void FixedUpdate()
    {
        
    }
    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            isDragged = true;
        }
    }
    

  
    private void OnMouseUp()
    {
        isDragged = false;
       
    }

    
    
}
