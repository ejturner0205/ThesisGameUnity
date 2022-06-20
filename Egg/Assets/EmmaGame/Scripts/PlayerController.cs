using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 target;
    private bool canMove;

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            canMove = true;
            target = new Vector2(mousePos.x, transform.position.y);

        }
        if (canMove)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);
        }
        if (transform.position.x == target.x)
        {
            canMove = false;
        }
    }
}
