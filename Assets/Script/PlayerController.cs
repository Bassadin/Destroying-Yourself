using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    public GameObject projectilePrefab;

    public Rigidbody2D playerRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRigidbody2D.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed));

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("ree");
        if (other.CompareTag("Enemy")) {
            other.GetComponent<EnemyBirdController>().bounceAway();
        }
    }
}
