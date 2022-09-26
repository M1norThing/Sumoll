using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;

    private Rigidbody enemyRB;
    private GameObject player;


    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 lookDirection = player.transform.position - transform.position;
        enemyRB.AddForce(lookDirection.normalized * speed);
        DestroyOutOfBounds();
    }

    private void DestroyOutOfBounds()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
