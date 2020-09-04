using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject arrow;
    public float SpeedArrow;
    private Vector2 mouesposs;
    public Camera Mousecam;
    public Rigidbody2D rbb;

    void Start()
    {
    }


    void Update() {
        mouesposs = Mousecam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) 
        {
            Rotation();
            Shoot();
          
        }
    }

    void Rotation()
    {
        Vector2 lookDir = mouesposs - rbb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        this.transform.rotation = Quaternion.Euler(lookDir.x, lookDir.y, angle);
    }
    void Shoot() {
        GameObject fire = Instantiate(arrow,transform.position,transform.rotation);
        if (fire != null)
        {
           
            Rigidbody2D rbb = fire.GetComponent<Rigidbody2D>();
            rbb.AddForce(this.transform.up * SpeedArrow, ForceMode2D.Impulse);
        } 
    }

}
