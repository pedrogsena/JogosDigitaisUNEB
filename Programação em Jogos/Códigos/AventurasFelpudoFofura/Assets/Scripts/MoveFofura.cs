using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveFofura : MonoBehaviour
{
	public float speed;
	public ParticleSystem coracao;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.position += Vector3.left * Time.deltaTime * speed;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Felpudo")
		{
			coracao.Play();
		}
	}
}