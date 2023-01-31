using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTavern : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(1);
            }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //if ((col.gameObject.tag = "trigger") && (Input.GetMouseButtonDown(0)))
        //{
            //SceneManager.LoadScene(1);
        //}
    }    
}
