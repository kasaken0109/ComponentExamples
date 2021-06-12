using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [SerializeField] Text m_text = null;
    InputField inputField = null;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextChange()
    {
        m_text.text = "あなたの名前：" + inputField.text;
    }

    public void TextChanging()
    {
        m_text.text = "入力中...";
    }
}
