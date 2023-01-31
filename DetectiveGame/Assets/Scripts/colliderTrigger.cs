using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static colliderTrigger;

public class colliderTrigger : MonoBehaviour
{
    public Collider2D gameObject1;
    public Collider2D gameObject2;
    public int buildIndex;
    

    private void triggerInteract()
    {
        if ((gameObject1.IsTouching(gameObject2)) && (Input.GetKeyDown("e")))
        {
            SceneManager.LoadScene(sceneBuildIndex:buildIndex);
        }
    }



    void Update()
    {
        triggerInteract();
    }
}
