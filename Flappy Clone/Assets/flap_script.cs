using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flap_script : MonoBehaviour
{

    [Header("Flapper Variables")]

    public Rigidbody2D myRigidbody;

    public int speed;

    public LogicScript logic;

    private bool alive = true;

    private float timer = 0;
    private bool flapping = false;

    [Header("Flapper Sound")]
    public AudioSource flap;
    public Animator animatior;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            moveup();
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            logic.gameOver();
            alive = false;
        }
    }

    void moveup()
    {
        myRigidbody.velocity = Vector2.up  * speed;
        flap.Play();
        animatior.Play("Flapping");
        timer = 0;
        
        

    }
}
