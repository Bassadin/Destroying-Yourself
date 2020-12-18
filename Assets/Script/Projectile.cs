using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        var index = Random.Range(0, sprites.Length);
        GetComponent<SpriteRenderer>().sprite = sprites[index];

        Rigidbody2D projectileRigidbody2D = GetComponent<Rigidbody2D>();
        projectileRigidbody2D.AddForce(new Vector2(Random.Range(minSpeed, maxSpeed), 0));
        projectileRigidbody2D.AddTorque(Random.Range(-130f, 130f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
