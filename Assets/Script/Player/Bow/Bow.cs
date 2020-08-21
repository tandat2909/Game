using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 lookDir;
    public GameObject arrow;
    public float SpeedArrow;
    private Vector2 mouesposs;
    public Camera Mousecam;
    public Rigidbody2D rbb;
    public static bool shoot = false;
    public static Bow bow;
    void Start()
    {
    }
    void Rotation() {
        lookDir = mouesposs - rbb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        this.transform.rotation = Quaternion.Euler(lookDir.x, lookDir.y, angle);
    }

    void Update() {
        mouesposs = Mousecam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("Shoot");
            Shoot();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rotation();
        
    }
    void Shoot() {
        GameObject fire = Instantiate(arrow, this.transform.position, this.transform.rotation);
        Rigidbody2D rbb = fire.GetComponent<Rigidbody2D>();
        rbb.AddForce(this.transform.up * SpeedArrow, ForceMode2D.Impulse);
    }

}
