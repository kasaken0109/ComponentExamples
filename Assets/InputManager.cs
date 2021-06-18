using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    /// <summary>入力されたテキストを反映するテキストボックス/// </summary>
    [SerializeField] Text m_text = null;
    InputField inputField = null;
    LineRenderer lineRenderer = null;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        lineRenderer = GameObject.Find("Panel").GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 入力が完了された時に変更を反映するための関数
    /// </summary>
    public void TextChange()
    {
        if (inputField.contentType == InputField.ContentType.IntegerNumber)
        {
            lineRenderer.positionCount = int.Parse(inputField.text);
            for (int i = 0; i < lineRenderer.positionCount; i++)
            {
                lineRenderer.SetPosition(i,new Vector3(i , i * i / 4,0));
            }
        }
        else if (inputField.contentType == InputField.ContentType.Standard)
        {
            m_text.text = "あなたの名前：" + inputField.text;
        }
    }

    /// <summary>
    /// 入力中にテキストの表示を変える関数
    /// </summary>
    public void TextChanging()
    {
        m_text.text = "入力中...";
    }
}
