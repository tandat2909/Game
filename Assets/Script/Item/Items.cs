
using System.Collections;
using UnityEngine;

public abstract class Items:MonoBehaviour
{
    [SerializeField]
    private IdItem Id;
    [SerializeField]
    private string nameItem;
    [SerializeField]
    private float thongSo;
    [SerializeField]
    private Sprite sourceImg;
    private bool statusItem = false;

    public bool StatusItem { set => statusItem = value; get => statusItem; }
    public float ThongSo { get => thongSo; set => thongSo = value; }
    public string NameItem { get => nameItem; set => nameItem = value; }
    public IdItem ID { set; get; }
   

    public abstract bool UseItem();
    public abstract bool TurnOffItem();

    

}
