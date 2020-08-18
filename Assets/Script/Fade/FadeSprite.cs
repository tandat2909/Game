using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSprite : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer Rend;
    void Start()
    {
        Rend = GetComponent<SpriteRenderer>();
    }

    IEnumerator FadeOut()
    {
        for(float f = 1f; f >= 0.5f; f -= 0.05f)
        {
            Color c = Rend.material.color;
            c.a = f;
            Rend.material.color = c;
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator FadeIn()
    {
        for (float f = 0.5f; f <= 1f; f += 0.05f)
        {
            Color c = Rend.material.color;
            c.a = f;
            Rend.material.color = c;
            yield return new WaitForSeconds(0.01f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag =="Player")
         StartCoroutine("FadeOut");       
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            StartCoroutine("FadeIn");
    }
}
