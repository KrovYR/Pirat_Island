using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector2 position = transform.position;

        //Move
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical;

        transform.position = position;

        mouseX = position.x - mouseX;
        mouseY = position.y - mouseY;


    }
}