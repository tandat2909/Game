using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
<<<<<<< HEAD
    public float moveSpeed = 1f;
    public Transform Gun;
    public Rigidbody2D rb;

    public Animator animator;
    public Camera cam;

    Vector2 mousePos;
    Vector2 movement;

=======
    public float moveSpeed = 7f;
    private Rigidbody2D rb;
    public Animator animator;
    private Vector2 change;

    void Start() {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
>>>>>>> Edit-map-1

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
=======
        change = Vector2.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine (AttackAnimation());
        }
        else
            UpdateAnimationAndMove();
    }
>>>>>>> Edit-map-1

    private IEnumerator AttackAnimation()
    {
        animator.SetBool("attacking", true);
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);

    }

    void UpdateAnimationAndMove() {
        if (change != Vector2.zero)
        {
            MovePlayer();
            animator.SetFloat("Horizontal", change.x);
            animator.SetFloat("Vertical", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MovePlayer()
    {
        rb.MovePosition(rb.position + change * moveSpeed * Time.deltaTime);
    }
    void FixedUpdate()
    {
<<<<<<< HEAD
        Vector2 move = rb.position + movement * moveSpeed * Time.fixedDeltaTime;

        //Debug.Log(transform.position.x + " y " + transform.position.y);

        rb.MovePosition(move);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        Gun.rotation = Quaternion.Euler(lookDir.x,lookDir.y,angle);
=======
        
>>>>>>> Edit-map-1
    }
}
