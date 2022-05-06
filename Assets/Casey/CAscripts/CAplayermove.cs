using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CAplayermove : MonoBehaviour
{
	public Animator animator;
	public float horizontalMove;
	//bool facingRight = true;

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
			TakeDamage(5);
		}
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == ("Health"))
        {
			Health(20);
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

		if (currentHealth <= 0)
		{
			LoseScreen();
		}

		horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
		
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

	}
 //   public void FixedUpdate()
 //   {
	//	if (speed > 0 && !facingRight)
	//	{
	//		Flip();
	//	}
	//	if (speed < 0 && !facingRight)
	//	{
	//		Flip();
	//	}
	//}

  //  void Flip()
  //  {
		//Vector3 currentScale = gameObject.transform.localScale;
		//currentScale.x *= 1;
		//gameObject.transform.localScale = currentScale;

		//facingRight = !facingRight;
  //  }

	public void LoseScreen()
	{
		SceneManager.LoadScene("Lose");
	}

	void TakeDamage(int damage)
    {
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
    }
	void Health(int health)
	{
		currentHealth += health;

		healthBar.SetHealth(currentHealth);
	}
}
