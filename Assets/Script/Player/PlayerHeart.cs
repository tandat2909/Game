
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeart : MonoBehaviour,IHealth
{
    public Slider sliderBlood;
    
    public float Blood = 100;
    public float MaxBlood = 100;
    
    
    void Start()
    {
        
        sliderBlood.maxValue = MaxBlood;
        sliderBlood.value = MaxBlood;
        
    }
    void FixedUpdate()
    {
        
        if (Blood <= 0)
        {
            sliderBlood.value = 0;
            Player die = GetComponent<Player>();
            die.status = false;
           
        }else
        sliderBlood.value = Blood;
    }
    


    public void _NoClickChanged()
    {
        sliderBlood.value = Blood;
    }

    public void TakeDamage(float damage)
    {
        Blood -= Blood - damage <= 0 ? 0 : damage;
       
    }

    public void AddHealth(float addHealth)
    {
       Blood = Blood + addHealth >= MaxBlood ? MaxBlood : Blood + addHealth;
    }
}
