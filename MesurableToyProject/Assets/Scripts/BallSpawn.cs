using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject redBallSpawner; // spawners for the various balls
    public GameObject blueBallSpawner;
    public GameObject yellowBallSpawner;
    public GameObject redBall; // the balls themselves
    public GameObject blueBall;
    public GameObject yellowBall;

    public float startRedSpawnTime; // used to reset the values for the timers
    public float startBlueSpawnTime;
    public float startYellowSpawnTime;
    private float redSpawnTime; // the time it takes for the balls to respawn
    private float blueSpawnTime;
    private float yellowSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // create a new red ball when the timer is less than zero and reset the timer
        if (redSpawnTime <= 0)
        {
            Instantiate(redBall, redBallSpawner.transform.position, redBall.transform.rotation);
            redSpawnTime = startRedSpawnTime;
        }
        // same thing for the blue ball
        else if (blueSpawnTime <= 0)
        {
            Instantiate(blueBall, blueBallSpawner.transform.position, blueBall.transform.rotation);
            blueSpawnTime = startBlueSpawnTime;
        }
        // same thing for the blue ball
        else if (yellowSpawnTime <= 0)
        {
            Instantiate(yellowBall, yellowBallSpawner.transform.position, yellowBall.transform.rotation);
            yellowSpawnTime = startYellowSpawnTime;
        }
        // decrease the timers over real time
        else
        {
            redSpawnTime -= Time.deltaTime;
            blueSpawnTime -= Time.deltaTime;
            yellowSpawnTime -= Time.deltaTime;
        }
    }
}
