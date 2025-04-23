using UnityEngine;

public class HelmetAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioIndonesia;
    public AudioClip audioEnglish;

    public void PlayHelmetExplanation()
    {
        StartCoroutine(PlayAudioSequence());
    }

    private System.Collections.IEnumerator PlayAudioSequence()
    {
        // Mainkan audio Indonesia
        audioSource.clip = audioIndonesia;
        audioSource.Play();

        // Tunggu sampai selesai
        yield return new WaitForSeconds(audioIndonesia.length);

        // Mainkan audio Inggris
        audioSource.clip = audioEnglish;
        audioSource.Play();
    }
}
