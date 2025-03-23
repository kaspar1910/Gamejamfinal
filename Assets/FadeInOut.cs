using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInOut : MonoBehaviour
{
    public Image fadeImage;

    void Start()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float alpha = 1;
        while (alpha > 0)
        {
            alpha -= Time.deltaTime / 2; // Justér hastigheden her
            fadeImage.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
        fadeImage.gameObject.SetActive(false); // Skjul UI-elementet, når faden er færdig
    }
}