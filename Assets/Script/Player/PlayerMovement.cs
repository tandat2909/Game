using System.Collections;

using UnityEngine;



public class PlayerMovement : MonoBehaviour,IIncreaseShoe
{
    // Start is called before the first frame update
   
    public float moveSpeed;
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
        change = new Vector2(0,0);
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0, 0);
        
        rb.constraints = change == new Vector2(0, 0) ? RigidbodyConstraints2D.FreezeAll: RigidbodyConstraints2D.FreezeRotation;
       

        mouespos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {

            StartCoroutine(AttackAnimation());

        }

    }

    void FixedUpdate()
    {
        
        UpdateAnimationAndMove();
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
        yield return null;
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
       // this.transform.position += change * moveSpeed * Time.deltaTime;
    }

    public void Add(float thongso)
    {
        moveSpeed += thongso;
    }
}
