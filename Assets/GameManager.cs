using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField]
    Transform m_spawn = null;
    public GameOption m_gameOption;
    [SerializeField]
    GameObject m_enemy;
    float enemyNum;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        m_gameOption = GameOption.EASY;
    }
    void Start()
    {
        if (!m_spawn)
        {
            Debug.Log("m_spawnがアサインされていません！");
        }
        else
        {
            
        }
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //}

    public enum GameOption
    {
        EASY,
        NORMAL,
        HARD,
    }

    public void GameOptionChanged(GameOption gameOption)
    {
        if (gameOption == GameOption.EASY)
        {
            enemyNum = 3;
        }
        else if (gameOption == GameOption.NORMAL)
        {
            enemyNum = 5;
        }
        else
        {
            enemyNum = 7;
        }
        List<GameObject> m_enemies = new List<GameObject>();
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var item in enemies)
        {
            m_enemies.Add(item);
        }
        foreach (var c in m_enemies)
        {
            Destroy(c);
        }
        m_enemies.Clear();
        
        for (int i = 0; i < enemyNum; i++)
        {
            Instantiate(m_enemy);
            m_enemy.transform.position = new Vector3(m_spawn.position.x + i * 2, m_spawn.position.y, m_spawn.position.z + i * 3);
        }
    }
}
