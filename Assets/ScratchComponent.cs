using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScratchComponent : MonoBehaviour
{
    public int maxScratches = 10;
    public int idealScratches = 7;
    public int scratchCount = 0;
    public int moneyEarned = 0;
    public TextMeshProUGUI scratchText;
    public TextMeshProUGUI moneyText;
    public GameObject endposition;
    public GameObject GoBackButton;
    
    
    public void Start()
    {
        moneyText = GameObject.Find("moneyText").GetComponent<TextMeshProUGUI>();
        scratchText = GameObject.Find("ScratchText").GetComponent<TextMeshProUGUI>();
        moneyText.text = $"money earned: {moneyEarned} kr";
        scratchText.text = $"scratches: {scratchCount}!";
        GoBackButton.SetActive(false);
    }
    

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scratchCount++;
            scratchText.text = $"scratches: {scratchCount}!";
            float intensity = (float) scratchCount / maxScratches * 2;
            GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.gray, intensity);
            
        }
    }

    public void goBack()
    {
        SceneManager.LoadScene(1);
    }
    
    
    
    public void EndButton()
    {
        CheckScratchStatus();
        gameObject.SetActive(false);
        moneyText.transform.position = endposition.transform.position; 
        moneyText.text = $"money earned: {moneyEarned} kr.";
        GoBackButton.SetActive(true);
    }
    

    private void CheckScratchStatus()
    {
        if (scratchCount == idealScratches)
        {
            moneyEarned = 100; 
            hidefront.MoneyTotal += moneyEarned;
            Debug.Log("Perfekt sabotage! Du tjener " + moneyEarned + " kr.");
        }
        else if (scratchCount < idealScratches)
        {
            moneyEarned = 50; 
            hidefront.MoneyTotal += moneyEarned;
            Debug.Log("Du ridser ikke nok, men får stadig " + moneyEarned + " kr.");
        }
        else if (scratchCount > idealScratches && scratchCount <= maxScratches)
        {
            moneyEarned = 20; 
            hidefront.MoneyTotal += moneyEarned;
            Debug.Log("Du har ridset lidt for meget. Du tjener kun " + moneyEarned + " kr.");
        }
        else
        {
            moneyEarned = 0; 
            hidefront.MoneyTotal += moneyEarned;
            Debug.Log("For mange ridser! Kunden opdager det, og du får ingenting.");
        }
    }
}
