using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private bool isOnGround;
    private float movement;
    public GameOver screen;
    private float score;

    public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        score += Time.deltaTime * 2;
        textScore.text = score.ToString();
        

        player.velocity = new Vector2(movement * 10.0f, player.velocity.y);
        if(Input.GetButtonDown("Jump") && isOnGround)
        {
            player.AddForce(new Vector2(player.velocity.x, 600.0f));
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("ground"))
            isOnGround = true;
    } 

    void OnCollisionExit2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("ground"))
            isOnGround = false;
    }

    void OnTriggerEnter2D(Collider2D obstacle)
    {
        if(obstacle.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
            screen.Setup(score);
        }
    }
}
