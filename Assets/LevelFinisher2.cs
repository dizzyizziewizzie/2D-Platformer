using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinisher2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)

    {
        Debug.Log("Teleport touched!");  
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level3");
        }
    }
}