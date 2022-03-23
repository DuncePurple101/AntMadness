using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAEnemyAI : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float RetreatDistance;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && (Vector2.Distance(transform.position, player.position) > RetreatDistance))
        {
            transform.position = this.transform.position;

        }else if (Vector2.Distance(transform.position, player.position) < RetreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
