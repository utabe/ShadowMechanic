using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightballScript : MonoBehaviour
{
    public CircleCollider2D ccd;
    public float speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        DestroySelf();
    }

    private void DestroySelf()
    {
        GameObject.Destroy(gameObject);
    }
}
