using UnityEngine;

public class AboutPanelController : MonoBehaviour
{
    public GameObject aboutUsPanel;

    public void ShowAboutUs()
    {
        aboutUsPanel.SetActive(true);
    }

    public void HideAboutUs()
    {
        aboutUsPanel.SetActive(false);
    }
}

