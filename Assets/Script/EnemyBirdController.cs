using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBirdController : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;

    private Rigidbody2D enemyRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
        enemyRigidbody.AddForce(new Vector2(-Random.Range(minSpeed, maxSpeed), 0));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile"))
        {
            bounceAway();
        }
    }

    public void bounceAway()
    {

        enemyRigidbody.velocity = new Vector2();
        enemyRigidbody.AddForce(new Vector2(Random.Range(110, 130), Random.Range(80, -80)));
        enemyRigidbody.AddTorque(Random.Range(-300, 300));
        Destroy(this, 8);
    }
}
