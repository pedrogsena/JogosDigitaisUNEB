using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveFelpudo : MonoBehaviour
{
//	public float forcaPulo;
	public float velocidade;
	private Rigidbody2D personagemJogavel;
	private SpriteRenderer spritePJ;
	public ParticleSystem coracao;
	public Text loseText;

	public float buttonTime = 5.0f;
    public float jumpHeight = 3;
    public float cancelRate = 100;
    float jumpTime;
    bool jumping = false;
    bool jumpCancelled = true;

	// Use this for initialization
	void Start()
	{

		personagemJogavel = GetComponent<Rigidbody2D>();
		spritePJ = GetComponent<SpriteRenderer>();
		spritePJ.flipX = false;
		loseText.text = "";

	}

	// Update is called once per frame
	void Update()
	{
		if(SceneManager.GetActiveScene().buildIndex == 3)
		{
			float horizontal = Input.GetAxis("Horizontal");
			if(horizontal >= 0)
				spritePJ.flipX = false;
			else spritePJ.flipX = true;
			// personagemJogavel.AddForce(new Vector2(horizontal * velocidade, 0), ForceMode2D.Impulse);
			personagemJogavel.velocityX = horizontal * velocidade;
			
			if (!jumping && Input.GetKeyDown(KeyCode.Space))
			{
				float jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * personagemJogavel.gravityScale));
				personagemJogavel.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
				jumping = true;
				jumpCancelled = false;
				jumpTime = 0;
			}
			if (jumping)
			{
				jumpTime += Time.deltaTime;
				if (Input.GetKeyUp(KeyCode.Space))
				{
					jumpCancelled = true;
				}
				if (jumpTime > buttonTime)
				{
					jumping = false;
				}
			}
    
			/*if (Input.GetKeyDown(KeyCode.Space))
				personagemJogavel.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);*/
		}
		else
		{
			transform.position += Vector3.right * Time.deltaTime * velocidade;
		}
	}
	
	void FixedUpdate()
    {
        if(jumpCancelled && jumping && personagemJogavel.velocity.y > 0)
        {
            personagemJogavel.AddForce(Vector2.down * cancelRate);
        }
    }			


	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Morreu")
		{
			
			loseText.text = "GAME OVER";
			float contaTempo = 0.0f;
			while(contaTempo < 3.0f)
			{
				Thread.Sleep(1000);
				contaTempo += 1.0f;
			}
			SceneManager.LoadScene("StartMenu");
		}

		if(other.gameObject.tag == "Coracao")
		{
			coracao.Play();
			float contaTempo = 0.0f;
			while(contaTempo < 3.0f)
			{
				Thread.Sleep(1000);
				contaTempo += 1.0f;
			}
			SceneManager.LoadScene("EndingCinematic");
		}
	}
}