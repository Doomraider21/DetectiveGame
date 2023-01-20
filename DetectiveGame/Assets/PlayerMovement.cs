using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20;
    private Vector2 motion;

    void Update()
    {
        motion = new Vector2(Input.GetAxisRaw("Horizontal"),0);
        transform.Translate(motion * speed * Time.deltaTime);
    }
}
