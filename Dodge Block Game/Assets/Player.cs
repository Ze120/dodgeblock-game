using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 15f;
    public float mapWidth = 5f;

    private Rigidbody2D rb;

    void Start () {

        // Call this rigidbody sprite infomation 
        rb = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate () {

        // Get input type horizontal and defind movement sprite
        float horizontalMove = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        // Store value next position sprite after get input 
        Vector2 newPosition = rb.position + (Vector2.right * horizontalMove);

        // Defind range sprite position in X-axis (Map Width) 
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        
        rb.MovePosition(newPosition);
    
    }
}
