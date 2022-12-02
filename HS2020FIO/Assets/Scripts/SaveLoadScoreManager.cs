using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadScoreManager : MonoBehaviour
{
    public HighScores m_HighScores;

    private float m_gameTime;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        m_gameTime = 0.0f;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        m_gameTime += Time.deltaTime;

        if (isGameOver == true)
        {
            // save the score
            m_HighScores.AddScore(Mathf.RoundToInt(m_gameTime));
            m_HighScores.SaveScoresToFile();
        }
    }
}
