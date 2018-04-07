using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour {
	public float playerMultiplier = 1.0f;
	public float speed = 1.0f;

    protected Animator anim;
	protected Rigidbody2D rb;

    // Use this for initialization
    protected virtual void Start () {
		rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Movement();
        OtherCommands();
	}

    void Movement()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        bool isWalking = Mathf.Abs(h) + Mathf.Abs(v) > 0;

        Vector3 movement = new Vector3(h * playerMultiplier, v, 0.0f).normalized * speed;
        if (isWalking)
        {
            anim.SetFloat("Right", movement.x);
            anim.SetFloat("Up", movement.y);

            transform.position += movement * Time.fixedDeltaTime;
            //rb.AddForce(movement);
        }

        anim.SetBool("IsWalking", isWalking);
    }

    protected virtual void OtherCommands(){ }
}
