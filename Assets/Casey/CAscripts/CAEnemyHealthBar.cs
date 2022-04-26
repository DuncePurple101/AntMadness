using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CAEnemyHealthBar : MonoBehaviour
{
    
    public Slider slider;


    public void Setmaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        //Debug.Log("MaxHealth set to " + health);
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        //Debug.Log("Health set to " + health);
    }
}
