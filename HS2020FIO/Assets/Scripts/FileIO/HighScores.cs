using UnityEngine;
using System.Collections;
using System.IO;
public class HighScores : MonoBehaviour
{
    public int[] scores = new int[10];
    string currentDirectory;
    [SerializeField] string scoreFileName = "highscores.txt";
    void Start()
    {
        // We need to know where we're reading from and writing to.
        // To help us with that, we'll print the current directory
        // to the console.
        currentDirectory = Application.dataPath;
        Debug.Log("Our current directory is: " + currentDirectory);
        // Load the scores by default.
        LoadScoresFromFile();
    }
    void Update()
    {
    }
    public void LoadScoresFromFile()
    {
    }
    public void SaveScoresToFile()
    {
    }
    public void AddScore(int newScore)
    {
    }
}