using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{

    [SerializeField] Vector3 force;

    [SerializeField] Sprite[] balloonSprites;
    private UI UI;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("UI").GetComponent<UI>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = balloonSprites[Random.Range(0, 5)];

        transform.position = new Vector3(Random.Range(-7.29f,7.29f),transform.position.y, transform.position.z);

        force = new Vector3(Random.Range(-100, 100), Random.Range(150, 250));

        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "top")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "bullet")
        {
            UI.AddScore();
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

    }
}
