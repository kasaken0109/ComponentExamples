using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    [SerializeField] float m_shrinkSpeed = 20f;
    RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float m_time = 0;
        m_time += Time.deltaTime;
        rectTransform.sizeDelta += new Vector2(-m_time * m_shrinkSpeed,-m_time * m_shrinkSpeed); 
    }
}
