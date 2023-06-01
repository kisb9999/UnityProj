using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GenerateObstacles generator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * generator.speed * Time.deltaTime);
        if(gameObject.name == "Obstacle(Clone)" && transform.position.x < -10)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("line"))
            generator.ObstacleRandomizer();
    }
}
