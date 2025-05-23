using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public void GantiKeRoom()
    {
        SceneManager.LoadScene("Room");
    }
}
