using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpForce = 7f;
    private float moveSpeed = 7f;
    private float dirX;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0f);
        }
        dirX = Input.GetAxisRaw("Horizontal");//left:-1, right:1
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }
}
