using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float moveSpeed = 100f;

    ParticleSystemRenderer particleSys;
    public GameObject particle;
    public Material[] mat;

    // Use this for initialization
    void Start()
    {
        particleSys = GetComponent<ParticleSystemRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            GameObject spark = Instantiate(particle, col.transform.position, col.transform.rotation) as GameObject;
            GameManager.Hp -= 1;
            particleSys = spark.GetComponent<ParticleSystemRenderer>();
            particleSys.material = mat[0];

            Destroy(col.gameObject);
        }

        else if (col.gameObject.tag == "Enemy1")
        {
            GameObject spark = Instantiate(particle, col.transform.position, col.transform.rotation) as GameObject;
            GameManager.Hp -= 1;
            particleSys = spark.GetComponent<ParticleSystemRenderer>();
            particleSys.material = mat[1];

            Destroy(col.gameObject);
        }

        else if (col.gameObject.tag == "Enemy2")
        {
            GameObject spark = Instantiate(particle, col.transform.position, col.transform.rotation) as GameObject;
            GameManager.Hp -= 1;
            particleSys = spark.GetComponent<ParticleSystemRenderer>();
            particleSys.material = mat[2];

            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Points")
        {
            GameObject spark = Instantiate(particle, col.transform.position, col.transform.rotation) as GameObject;
            particleSys = spark.GetComponent<ParticleSystemRenderer>();
            particleSys.material = mat[3];
            GameManager.Score += 1;
            Destroy(col.gameObject);
        }
    }
}
