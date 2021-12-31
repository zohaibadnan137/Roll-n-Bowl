using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    public float sensitivity = 20;
    
    private Rigidbody rb;
    private float screenWidth;

    void Start()
    {
        screenWidth = Screen.width;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.position.x > (screenWidth / 2))
                MoveRight();
            if(touch.position.x < (screenWidth / 2))
                MoveLeft();
        }
    }

    private void MoveRight()
    {
        rb.AddForce(new Vector3(sensitivity, 0, 0));
    }

    private void MoveLeft()
    {
        rb.AddForce(new Vector3((-1 * sensitivity), 0, 0));
    }
}
