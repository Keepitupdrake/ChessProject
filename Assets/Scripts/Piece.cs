using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Piece : MonoBehaviour
{

    public bool FirstMove { get; set; } = true;
    public bool dragged = false;
    public MouseFollower follow;

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool CanMove(Vector2 targetPos)
    {

        return true;
    }
    public abstract void Move();

    private void OnMouseDown()
    {
        if (dragged == false)
            follow.draggedPiece = this;
    }
}

 
