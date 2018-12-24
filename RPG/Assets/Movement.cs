using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float horizontalMove = 0f;
    public float runSpeed = 40f;
    public Animator animator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("hSpeed", Mathf.Abs(horizontalMove));
        gameObject.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalMove * Time.fixedDeltaTime, 0);
		
	}
}
