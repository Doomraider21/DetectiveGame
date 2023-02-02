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

    [SerializeField] private Transform player; //drag player reference onto here
    private Vector3 targetPosition; //here you store the position you want to teleport your player to

    private void SceneLoaded()
    {
        if (buildIndex == 0) //use your desired check here to compare your scene
        {
            player.position = targetPosition;
        }
    }

    void Update()
    {
        triggerInteract();
        SceneLoaded();
    }

}
