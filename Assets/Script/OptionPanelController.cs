using UnityEngine;

public class OptionPanelController : MonoBehaviour
{
    public GameObject optionPanel;

    public void ShowOptionPanel()
    {
        optionPanel.SetActive(true);
    }

    public void HideOptionPanel()
    {
        optionPanel.SetActive(false);
    }
}
