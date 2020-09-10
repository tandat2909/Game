
using UnityEngine;
using Assets.Data;
[CreateAssetMenu]
public class ConfigPlayer:ScriptableObject
{
    public string NamPlayer;
    public float Damage;
    public float Point;
    public float Blood;
    public float MaxBlood;
    public float moveSpeed;
    
    public void ReSet()
    {
        
    }

}

