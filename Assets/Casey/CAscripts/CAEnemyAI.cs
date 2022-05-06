using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAEnemyAI : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float RetreatDistance;
    public Animator animator;

    public int minRange;

    public Transform player;
    public Transform egg;
    private Transform target = null;

    public int maxHealth = 100;
    public int currentHealth;

    public CAEnemyHealthBar CAEnemyHealthBar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player") target = collision.transform;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "player") target = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        egg = GameObject.FindGameObjectWithTag("Egg").transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;

        currentHealth = maxHealth;
        CAEnemyHealthBar.Setmaxhealth(maxHealth);
    }

    public void TakeDamge(int damage)
    {
        currentHealth -= damage;
        CAEnemyHealthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
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

        /*
        if (target == null) return;
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        bool tooClose = distance < minRange;
        Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
        transform.Translate(direction * Time.deltaTime);
        */
    }
}


