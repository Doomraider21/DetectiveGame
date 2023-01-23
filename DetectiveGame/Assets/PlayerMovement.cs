using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;
    public Vector2 motion;
    public Animator animator;
    private float direction = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        motion = new Vector2(Input.GetAxisRaw("Horizontal"),0);
        transform.Translate(motion * speed * Time.deltaTime);

        direction = Input.GetAxisRaw("Horizontal");

        if (direction > 0f)
        {
            transform.localScale = new Vector2(4f, 4f);
        }
        else if (direction < 0f)
        {
            transform.localScale = new Vector2(-4f, 4f);
        }

        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        // takes negative float and makes it positive
    }
}
