using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CAplayer2move : MonoBehaviour
{
	public Animator animator;
	public float horizontalMove;

	private float speed = 10.0f;
	public GameObject charcter;

	public int maxHealth = 100;
	public int currentHealth;

	public CAHealthBar2 healthBar;

	void Start()
	{
		currentHealth = maxHealth;
		healthBar.Setmaxhealth(maxHealth);
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Enemy")
		{
			TakeDamage(5);
		}
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	public void LoseScreen()
    {
		SceneManager.LoadScene("Lose");
    }


	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}

		if (currentHealth <= 0)
        {
			LoseScreen();
        }

		horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
	}

}
