using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    [SerializeField] GameObject m_cube = null;
    [SerializeField] Slider slider = null;
    Color m_defaultColor;
    
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = m_cube.GetComponent<Renderer>();
        m_defaultColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeRed()
    {
        renderer.material.color = Color.red;
    }

    public void ChangeBlue()
    {
        renderer.material.color = Color.blue;
    }

    public void ChangeYellow()
    {
        renderer.material.color = Color.yellow;
    }

    public void ChangeDefault()
    {
        renderer.material.color = m_defaultColor;
    }

    public void ChangeSize()
    {
        float sizeValue = 2f * slider.value;
        m_cube.transform.localScale = new Vector3(sizeValue,sizeValue,sizeValue);
    }
}
