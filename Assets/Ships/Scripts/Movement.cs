using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    private Rigidbody2D rb;

    public int xAcc = 0;
    public int yAcc = 0;

    private int MAXFORWARDTHRUST = 10;
    private int MAXSIDETHRUST = 5;

	// Use this for initialization
	void Start () {

        // Get Rigidbody of Object
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        // Accellerate the Object
        rb.velocity = new Vector2(rb.velocity.x + xAcc, rb.velocity.x + yAcc);       
    }

    // Navigate to this location
    public void Move (float xpos, float ypos) {

        // Get current position
        float currentx = rb.position.x;
        float currenty = rb.position.y;
    }
}
