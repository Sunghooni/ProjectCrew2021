using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool canInput = true;
    private float horz;
    [SerializeField]private bool isGround;
    private const float moveSpeed = 5;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!canInput) return;

        horz = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
            isGround = false;
        }
    }


    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * horz * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}