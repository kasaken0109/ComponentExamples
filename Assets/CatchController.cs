using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchController : MonoBehaviour
{
    [SerializeField] float m_moveSpeed = 0.2f;
    FixedJoint fixedJoint;
    Transform m_origin;
    Rigidbody m_rb;
    // Start is called before the first frame update
    void Start()
    {
        m_origin = this.transform;
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 moveVector = new Vector2(h, v).normalized;
        float m_downSpeed = 0;
        if (Input.GetButton("Jump"))
        {
            Debug.Log("a");
            m_downSpeed = -m_moveSpeed;
        }
        else
        {
            Debug.Log("b");
            m_downSpeed = m_moveSpeed;
            if (transform.position.y > m_origin.position.y)
            {
                Debug.Log("c");
                m_downSpeed = 0;
            }
        }
        m_rb.velocity = new Vector3(moveVector.x * m_moveSpeed,m_downSpeed,moveVector.y * m_moveSpeed);
        Debug.Log(m_rb.velocity);

        if (Input.GetMouseButtonDown(1))
        {
            Destroy(fixedJoint);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        fixedJoint = gameObject.AddComponent<FixedJoint>();
        fixedJoint.connectedBody = other.GetComponent<Rigidbody>();
    }
}
