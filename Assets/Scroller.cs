using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{

    private BoxCollider2D collider;
    private Rigidbody2D body;
    private float scrollSpeed = -2.0f;
    private float screenWidth;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        body = GetComponent<Rigidbody2D>();
        screenWidth = collider.size.x;
        collider.enabled = false;

        body.velocity = new Vector2(scrollSpeed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -screenWidth){
            Vector2 resetPos = new Vector2(screenWidth * 2, 0);
            transform.position = (Vector2)transform.position + resetPos;
        }
    }
}
