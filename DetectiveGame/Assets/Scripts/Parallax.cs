using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startPos;
    // variable for length and start position of background sprites

    public GameObject Cam;

    public float parallaxEffect;
    // determines how much parallax effect will be applied

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        // finds length from the sprite renderer
    }

    void Update()
    {
        float temp = (Cam.transform.position.x * (1 - parallaxEffect));
        
        float dist = (Cam.transform.position.x * parallaxEffect);
        // how far the camera has moved in world space

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
        
        if (temp > startPos + length)
        {
            startPos += length;
        }

        else if (temp < startPos - length)
        {
            startPos -= length;
        }
        // background keeps repeating itself when out of frame for infinite background scroll
    }
}