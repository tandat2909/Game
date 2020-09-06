
using UnityEngine;

public class TocChay:Items
{
    public override void UseItem()
    {
        PlayerMovement movement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        movement.moveSpeed += ThongSo;
       // this.enabled = false;
    }

    void Awake()
    {

       // base.ThongSo = 3f;
        base.NameItem = "TocChay";
    }

}
