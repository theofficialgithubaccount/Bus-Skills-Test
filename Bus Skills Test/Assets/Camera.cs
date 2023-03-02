using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset= new Vector3(3.1f, 6.79f, -25.56f);
    public bool keyPress = false;
    public int switcher = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            switcher = 1 - switcher;
        }
        if (switcher == 1)
        {
            offset = new Vector3(2.407f, 2.212f, -8.89f);
        }
        else
        {
            offset = new Vector3(3.1f, 6.79f, -25.56f);
        }
        transform.position = offset;
    }
}
