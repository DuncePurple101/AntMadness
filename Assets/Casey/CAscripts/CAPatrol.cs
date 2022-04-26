using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAPatrol : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] Objectives;
    private int randomSpot;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, Objectives.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Objectives[randomSpot].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, Objectives[randomSpot].position) < 0.2f){
            if(waitTime <= 0)
            {
                randomSpot = Random.Range(0, Objectives.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
            

        }
        
    }
}
