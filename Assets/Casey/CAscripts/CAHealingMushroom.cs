using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAHealingMushroom : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(this.gameObject);
        }
    }

}
