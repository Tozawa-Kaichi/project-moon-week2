using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidsheat : MonoBehaviour
{
    Rigidbody2D m_rb;
    Animator m_anim;
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerBulletController>())
        {
            m_anim.Play("asteroids heat");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
