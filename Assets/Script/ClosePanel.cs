using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    public GameObject panel; // Drag panel kamu di sini dari inspector

    public void Close()
    {
        panel.SetActive(false); // Ini nutup panelnya
    }
}
