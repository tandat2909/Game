using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items:MonoBehaviour
{
    [SerializeField]
    private int idItem;
    [SerializeField]
    private string nameItem;
    [SerializeField]
    private float thongSo;
    [SerializeField]
    private string sourceImg;

    public float ThongSo { get => thongSo; set => thongSo = value; }
    public string NameItem { get => nameItem; set => nameItem = value; }
    public int IdItem { get => idItem; set => idItem = value; }
    public string SourceImg { get => sourceImg; set => sourceImg = value; }

    public abstract void UseItem();


}
