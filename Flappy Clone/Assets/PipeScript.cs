using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    [Header("Pipes")]
    public float moveSpeed = 5;
    public float pipeDeadspace = -75;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    
}
