using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 7f;
    public Rigidbody2D rb;
    public Animator animator;
    private Vector2 change;
    public Camera cam;
    public Vector2 mouespos;

    void Start() {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (Input.GetMouseButtonDown(0))
        {            
            StartCoroutine(AttackAnimation());
            Debug.Log("animation");
        }
        else
        {
            UpdateAnimationAndMove();
        }

        mouespos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private IEnumerator AttackAnimation()
    {
        MousePos();
        animator.SetBool("attacking", true);
        if (change != Vector2.zero)
        {
            animator.SetFloat("HorizontalMouse", change.x);
            animator.SetFloat("VerticalMouse", change.y);
        } 
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);       
    }
    void MousePos()
    {
        change = mouespos - rb.position;
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
    
}
