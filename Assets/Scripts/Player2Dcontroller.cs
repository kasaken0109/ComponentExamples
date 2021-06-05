using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Dcontroller : MonoBehaviour
{
    [SerializeField] float m_xMoveSpeed = 2f;
    [SerializeField] float m_yMoveSpeed = 2f;
    [SerializeField] float m_jumpPower = 5f;
    Rigidbody2D m_rb = null;
    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<Rigidbody2D>(out m_rb))
        {
            gameObject.AddComponent<Rigidbody2D>();
        }
        m_rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float m_time = 0;
        m_time += Time.deltaTime; 
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        m_rb.velocity = new Vector2(inputX * m_xMoveSpeed, inputY * m_yMoveSpeed - m_rb.gravityScale * m_time);
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        m_rb.AddForce(new Vector2(0,1) * m_jumpPower, ForceMode2D.Impulse);
    }
}
