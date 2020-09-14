using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour
{
    // Start is called before the first frame update
    public ConfigPlayer config;

    public GameObject arrow;
    public GameObject Ulti;
    public float SpeedArrow;
    private Vector2 mouesposs;
    public Camera Mousecam;
    public Rigidbody2D rbb;
    public bool UltiActive = false;
   
    public int amoutUlti;
  
    public int countUlti;
    [SerializeField]
    private Image ItemUltimate;
    private Text txtCountUlti;


    void Start()
    {
        
        countUlti = amoutUlti =5;
        txtCountUlti = ItemUltimate.gameObject.GetComponentInChildren<Text>();
    }


    void Update() {


        if (GameObject.Find("Player").GetComponent<Player>().status)
        {
            txtCountUlti.text = UltiActive ? countUlti.ToString() : "";

            mouesposs = Mousecam.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0))
            {
                if (UltiActive)
                {
                    CountUlti();
                }
                Rotation();
                Shoot();

            }
        }
        
    }

    void Rotation()
    {
        Vector2 lookDir = mouesposs - rbb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        this.transform.rotation = Quaternion.Euler(lookDir.x, lookDir.y, angle);
    }
    void Shoot() {
        arrow.GetComponent<Arrow>().Damage = config.Damage;
        GameObject fire = Instantiate(UltiActive ? Ulti: arrow, transform.position, transform.rotation) ;
        if (fire != null)
        {
            Rigidbody2D rbb = fire.GetComponent<Rigidbody2D>();
            rbb.AddForce(this.transform.up * SpeedArrow, ForceMode2D.Impulse);
        }
        FindObjectOfType<AudioManager>().PlaySound("PlayerShotting");
    }

    void FixedUpdate()
    {
        
    }

    void CountUlti() {

        if (countUlti == 0)
        {
            UltiActive = false;
            countUlti = amoutUlti;
            ItemUltimate.enabled = false;

        }
        else
        { countUlti--;
            FindObjectOfType<AudioManager>().PlaySound("ShottingItem4");
        }


    }

    
}
