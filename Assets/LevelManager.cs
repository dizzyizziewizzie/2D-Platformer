using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    void OpenFirst()
    {
        SceneManager.LoadScene("Level1");
    }
}