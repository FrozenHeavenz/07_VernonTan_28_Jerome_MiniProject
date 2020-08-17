using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    public GameObject Player;

    public float speed;
    public float step;

    public Vector3 SpawnPos;

    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        targetPosition = (Player.transform.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPos = transform.position;

        step = speed * Time.deltaTime;

        transform.position += targetPosition * speed * Time.deltaTime;

        Destroy(gameObject, 8f);
    }

}
