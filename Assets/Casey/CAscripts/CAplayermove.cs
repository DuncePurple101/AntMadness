using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAplayermove : MonoBehaviour
{
	private float speed = 10.0f;
    public GameObject charcter;

	public int maxHealth = 100;
	public int currentHealth;

	public CAHealthBar healthBar;

    void Start()
    {
		currentHealth = maxHealth;
		healthBar.Setmaxhealth(maxHealth);
    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.tag == "Enemy")
		{
			TakeDamage(20);
		}
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}

	void TakeDamage(int damage)
    {
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
    }
}
