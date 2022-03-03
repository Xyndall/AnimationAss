using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDeCharacter : MonoBehaviour
{
    public float speed = 2f;
    public float maxSpeed = 5f;
    private float moveInput;
    private bool facingRight = true;
    Animator _animator;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Attack");
        }
        
        
    }

    private void FixedUpdate()
    {
        

        moveInput = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector2(moveInput * speed, 0f));
        _animator.SetFloat("xvel", Mathf.Abs(moveInput));

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
