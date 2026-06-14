using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinisher44 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level5");
        }
    }
}