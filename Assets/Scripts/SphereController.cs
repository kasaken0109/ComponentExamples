using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    /// <summary>公転運動の中心 /// </summary>
    [SerializeField] Transform m_aim = null;
    /// <summary>公転半径/// </summary>
    [SerializeField] float m_rotateLength = 3;
    /// <summary>公転速度 /// </summary>
    float m_speed;
    /// <summary>公転運動の速さ /// </summary>
    float m_time;
    // Start is called before the first frame update
    void Start()
    {
        //公転速度をランダムに決定
        m_speed = Random.Range(0.1f, 2);
    }

    // Update is called once per frame
    void Update()
    {
        //時間経過処理
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
