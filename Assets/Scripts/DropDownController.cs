using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownController : MonoBehaviour
{
    [SerializeField] Dropdown m_dropDown = null;
    
    // Start is called before the first frame update
    void Start()
    {
        m_dropDown = GetComponent<Dropdown>();
        
    }

    // Update is called once per frame
    public void DroppDownSelected()
    {
        switch (m_dropDown.value)
        {
            case 0: GameManager.Instance.GameOptionChanged(GameManager.GameOption.EASY);
                break;
            case 1:
                GameManager.Instance.GameOptionChanged(GameManager.GameOption.NORMAL);
                break;
            case 2:
                GameManager.Instance.GameOptionChanged(GameManager.GameOption.HARD);
                break;
            default:
                break;
        }
    }

    
}
