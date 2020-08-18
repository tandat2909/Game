using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 1f;
    public Transform Sung;
    public Rigidbody2D rb;

    public Animator animator;
    public Camera cam;

    Vector2 mousePos;
    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        Vector2 move = rb.position + movement * moveSpeed * Time.fixedDeltaTime;

        //Debug.Log(transform.position.x + " y " + transform.position.y);

        rb.MovePosition(move);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        Sung.rotation = Quaternion.Euler(lookDir.x,lookDir.y,angle);
    }
}
