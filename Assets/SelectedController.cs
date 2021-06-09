using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedController : MonoBehaviour
{
    [SerializeField] Dropdown m_dropdown = null;
    Vector3 m_mousePosition = Vector3.zero;
    bool m_selectedFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //m_mousePosition = Input.mousePosition;
        //m_mousePosition.z = transform.position.z;
        if (m_selectedFlag)
        {
            m_dropdown.gameObject.SetActive(true);
        }
        else
        {
            m_dropdown.gameObject.SetActive(false);
        }
    }

    public void Selected()
    {
        if (!m_dropdown)
        {
            Debug.Log("DropDownがアサインされていません！");
            return;
        }
        if (!m_selectedFlag)
        {
            m_selectedFlag = true;
        }
        else
        {
            m_selectedFlag = false;
        }
    }

    public void DisSelected()
    {
        if (!m_dropdown)
        {
            Debug.Log("DropDownがアサインされていません！");
            return;
        }
        m_dropdown.gameObject.SetActive(false);
    }


}
