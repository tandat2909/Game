
using UnityEngine;

public class Blood: Items
{
    public override void UseItem()
    {
       IHealth health = GameObject.FindWithTag("Player").GetComponent<IHealth>();
        health.AddHealth(base.ThongSo);
    }

    void Awake()
    {
        NameItem = "Blood";
        //base.ThongSo = 20f;
    }
    
}
