using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour {
private Rigidbody rb;
public float velocidade;

//public bool giraEsquerda;
//public bool giraDireita;
//public Vector3 angVelLeft = new Vector3(0.0f, 100f, 0.0f);
//public Vector3 angVelRight = new Vector3(0.0f, -100f, 0.0f);

public float angVel = 100.0f;

private int count;
private int countMAX = 13;
public Text countText;
public Text winText;

void SetCountText() {
countText.text = "Count: " + count.ToString() + "/" + countMAX.ToString();
if (count >= countMAX) // picked up everything
winText.text = "YOU WIN!";
}
void Start () {
rb = GetComponent<Rigidbody>();
count = 0;
SetCountText();
winText.text = "";
}
void Update () {

//float movimentoLateral = 0.0f;
//movimentoLateral -= (float)Math.Sqrt(2.0f)/2.0f;
//movimentoLateral += (float)Math.Sqrt(2.0f)/2.0f;//Input.GetAxis("Horizontal");
//float movimentoFrontal = 0.0f;
//movimentoFrontal -= (float)Math.Sqrt(2.0f)/2.0f;
//movimentoFrontal += (float)Math.Sqrt(2.0f)/2.0f;//Input.GetAxis("Vertical");
//if(Input.GetKey(KeyCode.LeftArrow)) rotAng += turnSpeed;
//else if(Input.GetKey(KeyCode.RightArrow)) rotAng -= turnSpeed;
//Vector3 movimento = new Vector3(movimentoFrontal*(float)Math.Cos(rotAng) - movimentoLateral*(float)Math.Sin(rotAng), 0.0f, movimentoFrontal*(float)Math.Sin(rotAng) + movimentoLateral*(float)Math.Cos(rotAng));

if(Input.GetKey(KeyCode.A)) rb.position -= transform.right * velocidade * Time.deltaTime;
if(Input.GetKey(KeyCode.D)) rb.position += transform.right * velocidade * Time.deltaTime;
if(Input.GetKey(KeyCode.S)) rb.position -= transform.forward * velocidade * Time.deltaTime;
if(Input.GetKey(KeyCode.W)) rb.position += transform.forward * velocidade * Time.deltaTime;

if(Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(0,-1*angVel*Time.deltaTime,0);
if(Input.GetKey(KeyCode.RightArrow)) transform.Rotate(0,1*angVel*Time.deltaTime,0);
}


void OnTriggerEnter(Collider other) {
if (other.gameObject.tag == "PickUp")
{
other.gameObject.SetActive(false);
count = count + 1;
SetCountText();

}
}
}