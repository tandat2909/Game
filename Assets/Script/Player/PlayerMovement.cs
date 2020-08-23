using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveSpeed;
    public Rigidbody2D rb;
    public Animator animator;
    private Vector3 change;
    
    public Camera cam;
    public Vector2 mouespos;

    void Start() {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

       // cam.transform.position = new Vector3(transform.position.x, transform.position.y, -5f);
        
        mouespos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            
            StartCoroutine(AttackAnimation());
            
        }
        else
        {
            
            UpdateAnimationAndMove();
        }

        
    }

    private IEnumerator AttackAnimation()
    {
        MousePos();
        animator.SetBool("attacking", true);
        if (change != Vector3.zero)
        {
            animator.SetFloat("HorizontalMouse", change.x);
            animator.SetFloat("VerticalMouse", change.y);
        } 
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.1f);       
    }
    void MousePos()
    {
        change = mouespos - rb.position;
    }

    void UpdateAnimationAndMove() {
        if (change != Vector3.zero)
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
       // rb.MovePosition(rb.position + change * moveSpeed * Time.deltaTime);
        this.transform.position += change * moveSpeed * Time.deltaTime;
    }
   
}
