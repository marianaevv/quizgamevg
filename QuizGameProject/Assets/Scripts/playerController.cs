using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    //movement
    public float maxSpeed;
    //jumping
   bool grounded = false;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpHeigh;
   

    Rigidbody2D myRB;
    Animator myAnim;
    bool facingRight;


    //SCORE
    public gameMaster gm;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
       facingRight = true;
     // gm =  GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
	}
    // Update is called once per frame
  private void Update()
    {
        if (grounded && Input.GetAxis("Jump") > 0)
        {
            grounded = false;
            myAnim.SetBool("isGrounded", grounded);
            myRB.AddForce(new Vector2(0, jumpHeigh));
        }
       
    }

    void FixedUpdate () {
        //check if we are on the ground, if not we are falling
       grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
       myAnim.SetBool("isGrounded", grounded);
       myAnim.SetFloat("verticalSpeed", myRB.velocity.y);

        float move = Input.GetAxis("Horizontal");
        myAnim.SetFloat("speed", Mathf.Abs(move));
        myRB.velocity = new Vector2(move*maxSpeed, myRB.velocity.y);
        if (move > 0 && !facingRight) {
            flip();
        } else if ( move<0 && facingRight)  {
            flip();
        }
	}
    //Method that make the player move fron right to left and viceversa
    void flip() {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    //Method that define the score that each egg gives and add to the score.
   /* private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Egg"))
        {
            Destroy(col.gameObject);
            // gm.points += 1; }
            gameMaster.points += 5;
        }
        else if (col.CompareTag("GoldenEgg"))
        {
            Destroy(col.gameObject);
            //  gm.points += 5;
            gameMaster.points += 15;
        }
     }*/
}
