using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject exitConfirmPanel;

    // Ketika klik tombol Exit
    public void OnExitButtonClicked()
    {
        mainMenuPanel.SetActive(false);       // Sembunyikan menu utama
        exitConfirmPanel.SetActive(true);     // Tampilkan panel konfirmasi
    }

    // Ketika klik tombol "No"
    public void OnCancelExit()
    {
        exitConfirmPanel.SetActive(false);    // Sembunyikan panel konfirmasi
        mainMenuPanel.SetActive(true);        // Tampilkan kembali menu utama
    }

    // Ketika klik tombol "Yes"
    public void OnConfirmExit()
    {
        Application.Quit();                   // Keluar aplikasi
        Debug.Log("Application exited.");     // Log saat di Editor
    }
}
