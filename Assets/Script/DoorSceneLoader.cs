using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneLoader : MonoBehaviour
{
    public string sceneToLoad;  // <-- Nama variabel diperjelas

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Pindah ke scene: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
