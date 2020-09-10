
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeart : MonoBehaviour,IHealth
{
    public ConfigPlayer config;
  
    public void TakeDamage(float damage)
    {
       config.Blood -= damage;
        
       
    }
    public void AddHealth(float addHealth)
    {
       config.Blood = config.Blood + addHealth >= config.MaxBlood ?config.MaxBlood :config.Blood + addHealth;
    }
}
