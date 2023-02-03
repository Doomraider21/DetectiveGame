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

<<<<<<< Updated upstream

=======

    void Update()
    {
        triggerInteract();
    }

}

public class SceneLoadActions
{
    [SerializeField] private Transform Player; //drag player reference onto here
    private Vector3 targetPosition; //here you store the position you want to teleport your player to


    private void OnEnable()
    {
        SceneManager.sceneLoaded += SceneLoaded; //You add your method to the delegate
    }
>>>>>>> Stashed changes

    private void OnDisable()
    {
<<<<<<< Updated upstream
        triggerInteract();
    }
=======
        SceneManager.sceneLoaded -= SceneLoaded;
    }

    //After adding this method to the delegate, this method will be called every time
    //that a new scene is loaded. You can then compare the scene loaded to your desired
    //scenes and do actions according to the scene loaded.
    private void SceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Player.position = targetPosition;
    }
>>>>>>> Stashed changes
}
