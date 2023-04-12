using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;
    private float timer = 0;
    private bool gameStarted = false;

    public LogicScript logic;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.gameIsStarted)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else if (!logic.gameIsOver)
            {
                timer = 0;
                spawnPipe();
            }
            if (!gameStarted)
            {
                spawnPipe();
                gameStarted = true;
            }
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint)), transform.rotation);
    }
}
