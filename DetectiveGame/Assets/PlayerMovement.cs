using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20;
    public Vector2 motion;
    public Animator animator;

    void Update()
    {
        motion = new Vector2(Input.GetAxisRaw("Horizontal"),0);
        transform.Translate(motion * speed * Time.deltaTime);

        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        // takes negative float and makes it positive
    }

    void FixedUpate()
    {

    }
}
