using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAEgg : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public EggHealthBar EggHealthBar;


    // Start is called bdefore the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        EggHealthBar.Setmaxhealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(20);
            //Debug.Log("Protect the egg!!");
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        EggHealthBar.SetHealth(currentHealth);
    }
}
