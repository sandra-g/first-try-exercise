using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpyPlatform : MonoBehaviour
{
    private float jumpForce = 7f;
    private float activeForce = 0f;
    private enum MovementState {idle, active};
    private MovementState state;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activeForce > .1f)
        {
            activeForce -= .1f;
        }
        if (activeForce > .1f)
        {
            state = MovementState.active;
        }
        else
        {
            state = MovementState.idle;
        }
        anim.SetInteger("state", (int)state);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, jumpForce, 0f);
            activeForce = 15f;//activo la plataforma
        }
    }
}
