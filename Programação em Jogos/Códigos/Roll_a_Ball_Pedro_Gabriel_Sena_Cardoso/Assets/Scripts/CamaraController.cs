using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI; 
public class CamaraController : MonoBehaviour { 
public GameObject player; 
private Vector3 deslocamento; 

public float rotAng = 0.0f;
public float turnSpeed = 0.1f;

void Start () { 
deslocamento = transform.position; 
} 
void Update () { 

//if(Input.GetKey(KeyCode.LeftArrow)) rotAng += turnSpeed;
//else if(Input.GetKey(KeyCode.RightArrow)) rotAng -= turnSpeed;
//transform.eulerAngles = new Vector3(0, -rotAng, 0);

transform.position = player.transform.position + deslocamento; 
} 
}

