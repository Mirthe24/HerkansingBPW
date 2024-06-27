using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // The name of the scene to switch to
    public string sceneName;

    // This method is called when another collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the tag "Player" or any other condition you need
        if (other.CompareTag("Player"))
        {
            // Switch the scene
            SceneManager.LoadScene(sceneName);
        }
    }
}
