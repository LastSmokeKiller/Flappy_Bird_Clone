using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flap_script : MonoBehaviour
{

    [Header("Flapper Variables")]

    public Rigidbody2D myRigidbody;

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveup();
        }
    }


    void moveup()
    {
        myRigidbody.velocity = Vector2.up  * speed;
    }
}
