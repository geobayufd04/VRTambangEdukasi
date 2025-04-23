using UnityEngine;

public class HelmInfoTrigger : MonoBehaviour
{
    public GameObject infoPanel; // Panel yang akan ditampilkan saat helm diklik

    public void ShowInfo()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Info Panel belum di-assign di Inspector!");
        }
    }
}
