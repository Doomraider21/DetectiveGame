using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interact : MonoBehaviour
{
    float raycastDistance = 10f; //Adjust to suit your use case

    //public Text interactText; //Create GUI Canvas on your scene if you havnt already and a UI Text Element in a suitable location on your screen and apply it to this Text variable

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, raycastDistance);

        if (hit.collider != null)
        {
            Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
            //Item Raycast Detection
            if (hit.collider.CompareTag("tavern"))//Checking if the Raycast has hit a collider with the tag of trigger
            {
                //interactText.text = "Press [E] to enter."; //Setting the Interaction Text to let the player know they are now hovering an interactable object

                if (Input.GetMouseButtonDown(0))//Check if the player has pressed the Interaction button
                {
                    SceneManager.LoadScene(1);
                }
            }
        }

    }
}