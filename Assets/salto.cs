using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioJump : MonoBehaviour
{
    public float jumpForce = 5f;        // Fuerza de salto
    public float fallMultiplier = 2.5f; // Factor de caída para un salto más suave
    public float lowJumpMultiplier = 2f; // Factor de caída para un salto más controlado



    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        // Si estás cayendo, aplica el multiplicador de caída para un salto más suave
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        // Si estás subiendo y no mantienes presionada la tecla de salto, aplica el multiplicador de caída para un salto más controlado
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}