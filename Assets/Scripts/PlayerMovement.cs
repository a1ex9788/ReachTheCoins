using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpPower;
    public float jumpDownPower;
    
    private int jumpCount;

    private void Start()
    {
        jumpCount = 2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Floor") {
            gameObject.GetComponent<Animator>().SetBool("Move", false);
            gameObject.GetComponent<Animator>().SetBool("Flying", false);
            gameObject.GetComponent<Animator>().SetBool("FallHit", false);
            jumpCount = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && jumpCount > 0) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPower * Time.deltaTime));
            jumpCount--;
            gameObject.GetComponent<Animator>().SetBool("Flying", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -jumpDownPower * Time.deltaTime));
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            gameObject.GetComponent<Animator>().SetBool("FallHit", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            gameObject.GetComponent<Animator>().SetBool("Move", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            gameObject.GetComponent<Animator>().SetBool("Move", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }



        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A)) {
            gameObject.GetComponent<Animator>().SetBool("Move", false);
        }
    }
}
