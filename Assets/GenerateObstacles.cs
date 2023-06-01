using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float speed;
    float multiplier; 

    // Start is called before the first frame update
    void Start()
    {
        addObstacle();
        multiplier = 0.0009f;
    }

    // Update is called once per frame
    void Update()
    {
        speed += multiplier;
    }

    public void addObstacle()
    {
       GameObject obstacleClone = Instantiate(obstacle, transform.position, transform.rotation);  
       obstacleClone.GetComponent<Obstacle>().generator = this;
    }

    public void ObstacleRandomizer()
    {
        float rand = Random.Range(0.1f, 1.1f);
        Invoke("addObstacle", rand);
    }
}
