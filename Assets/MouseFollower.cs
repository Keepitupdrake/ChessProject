using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    Vector3 desiredPosition = new Vector3();
    public Vector3 offset = new Vector3(1f, 1f, 10f);
    public Piece draggedPiece;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the object
        desiredPosition = Input.mousePosition + offset;
        transform.position = Camera.main.ScreenToWorldPoint(desiredPosition);

        if (draggedPiece != null)
            draggedPiece.transform.position = Camera.main.ScreenToWorldPoint(desiredPosition);

        if (Input.GetMouseButtonUp(0) && draggedPiece != null)
            draggedPiece.dragged = true;

        if (Input.GetMouseButtonDown(0) && draggedPiece != null && draggedPiece.dragged == true)
        {
            Drop();
        }
    }
  
    // Drop the Piece on the board
    public void Drop()
    {
        draggedPiece.transform.position = Camera.main.ScreenToWorldPoint(desiredPosition);
        draggedPiece.dragged = false;
        draggedPiece = null;
    }

   
}
