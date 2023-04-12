using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    [Header("Pipes")]
    public float moveSpeed = 5;
    public float pipeDeadspace = -75;
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < pipeDeadspace)
        {
            Debug.Log("Pipe Eliminated");
            Destroy(gameObject);
        }

        if (logic.gameIsOver == true) moveSpeed = 0;
 
    }

    


}
