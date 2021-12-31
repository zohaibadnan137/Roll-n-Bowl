using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactions : MonoBehaviour
{
    private int pickUpCount;
    private Vector3 scale;
    private bool canDestroy;

    void Start()
    {
        pickUpCount = 0;  
        canDestroy = false; 
        scale = new Vector3(1, 1, 1);     
    }

    void Update()
    {
        if(pickUpCount >= 3 && canDestroy == false)
        {
            pickUpCount = 0;
            transform.localScale += scale;
            canDestroy = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            if(pickUpCount < 3)
                pickUpCount++;
        }

        if(other.gameObject.CompareTag("Obstacle"))
        {
            if(canDestroy == true)
            {
                other.gameObject.SetActive(false);
                canDestroy = false;
                transform.localScale = scale;
            }
            else
            {
                if(SceneManager.GetActiveScene().buildIndex == 1)
                    SceneManager.LoadScene("Lose1");
                if(SceneManager.GetActiveScene().buildIndex == 2)
                    SceneManager.LoadScene("Lose2");
            }
        }

        if(other.gameObject.CompareTag("Finish"))
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
                SceneManager.LoadScene("Level2");
            if(SceneManager.GetActiveScene().buildIndex == 2)
                SceneManager.LoadScene("Win");
        }
    }
}
