using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAHealingMushroom : MonoBehaviour
{
    public CAHealthBar healthBar;
    public CAHealthBar2 healthBar2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == ("Health"))
        {
            
        }
    }
}
