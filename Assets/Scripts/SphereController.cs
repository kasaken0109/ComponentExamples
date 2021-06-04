using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] Transform m_aim = null;
    [SerializeField] float m_rotateLength = 3;
    float m_speed;
    float m_time;
    // Start is called before the first frame update
    void Start()
    {
        m_speed = Random.Range(0.1f, 2);
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;
        CircularMotion(m_time * m_speed);
    }

    /// <summary>
    /// 時間経過に応じて円運動をさせる
    /// </summary>
    /// <param name="time">経過時間</param>
    void CircularMotion(float time)
    {
        float m_xPosition = Mathf.Cos(time) * m_rotateLength + m_aim.position.x;
        float m_zPosition = Mathf.Sin(time) * m_rotateLength + m_aim.position.z;

        this.transform.localPosition = new Vector3(m_xPosition, 0,m_zPosition);
    }
}
