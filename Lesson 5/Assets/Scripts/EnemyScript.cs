using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 3.0f;
    public Transform endPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 2){
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, Time.deltaTime * speed);
        }
    }
    void OnCollisionStay(Collision collision){
        if (collision.gameObject.name == "Ball"){
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*200*speed);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward*250*speed*-1);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right*150*Random.value);
        }
    }
}
