
using UnityEngine;
using UnityEngine.UI;

public class Slider_Hearlt : MonoBehaviour
{
    public ConfigPlayer config;
    public Slider sliderHearlt;

    void Start()
    {

        updateValueSlier();

    }

    void FixedUpdate()
    {
        updateValueSlier();
    }
    void updateValueSlier()
    {

        sliderHearlt.value = config.Blood <= 0 ? 0 : config.Blood;
        sliderHearlt.maxValue = config.MaxBlood;
    }
    public void _NoClickChanged()
    {
        sliderHearlt.value = config.Blood;
    }

}
