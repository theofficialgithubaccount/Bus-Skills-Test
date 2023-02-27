using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset= new Vector3(4.8f, 1, -7);
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
            offset = new Vector3(0, 1, 0);
        }
        else
        {
            offset = new Vector3(4.8f, 1, -7);
        }
        transform.position = player.transform.position + offset;
    }
}
