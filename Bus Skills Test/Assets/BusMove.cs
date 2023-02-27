using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMove : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 45.0f;
    private float horizontalinput;
    private float fowardinput;
    // Update is called once per frame
    void Update()
    {
        //Move the vehicle foward
        horizontalinput = Input.GetAxis("Horizontal");
        fowardinput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardinput);
        transform.Rotate(Vector3.up, turnspeed * horizontalinput * Time.deltaTime);

    }
}
