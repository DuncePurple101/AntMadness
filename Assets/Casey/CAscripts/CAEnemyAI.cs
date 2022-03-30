using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAEnemyAI : MonoBehaviour
{
    private const string V = "Player";
    public float speed;
    public float stoppingDistance;
    public float RetreatDistance;

    public Transform player;
    public Transform egg;

    // Start is called before the first frame update
    void Start()
    {
        egg = GameObject.FindGameObjectWithTag("Egg").transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, egg.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, egg.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, egg.position) < stoppingDistance && (Vector2.Distance(transform.position, egg.position) > RetreatDistance))
        {
            transform.position = this.transform.position;

        }
        else if (Vector2.Distance(transform.position, egg.position) < RetreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, egg.position, -speed * Time.deltaTime);
        }
        
        
    }
}


