using UnityEngine;
using System.Collections;

public class MovTest : MonoBehaviour {

    //Variables
    public Rigidbody2D rb;
    public int xVelocity;
    public int yVelocity;

    private bool cycle = false;

    // Use this for initialization
    void Start () {
        // Get object's Rigidbody
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        // Test for keyboard input
        if(Input.GetKeyDown("space")) {
            // Set the velocity of Rigidbody to x&y velocity
            rb.velocity = new Vector2(xVelocity, yVelocity);
        }

	}
}
