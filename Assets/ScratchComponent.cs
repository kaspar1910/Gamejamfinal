using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScratchComponent : MonoBehaviour
{
    public int maxScratches = 10;
    public int idealScratches = 7;
    public int scratchCount = 0;
    public int moneyEarned = 0;
    public bool taskActive = false;
    
    public TextMeshProUGUI moneyText;
    public Button startTaskButton;
    public Button endTaskButton;

    public void Start()
    {
        moneyText = GameObject.Find("moneyText").GetComponent<TextMeshProUGUI>();
        startTaskButton = GameObject.Find("startTaskButton").GetComponent<Button>();
        endTaskButton = GameObject.Find("endTaskButton").GetComponent<Button>();
        
        startTaskButton.onClick.AddListener(StartTask);
        endTaskButton.onClick.AddListener(EndTask);
    }

    public void StartTask()
    {
        
    }

    public void EndTask()
    {
        
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scratchCount++;
            
            float intensity = (float) scratchCount / maxScratches;
            GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.gray, intensity);
            CheckScratchStatus();
        }
        
    }

    private void CheckScratchStatus()
    {
        if (scratchCount == idealScratches)
        {
            moneyEarned = 100; 
            Debug.Log("Perfekt sabotage! Du tjener " + moneyEarned + " kr.");
        }
        else if (scratchCount < idealScratches)
        {
            moneyEarned = 50; 
            Debug.Log("Du ridser ikke nok, men får stadig " + moneyEarned + " kr.");
        }
        else if (scratchCount > idealScratches && scratchCount <= maxScratches)
        {
            moneyEarned = 20; 
            Debug.Log("Du har ridset lidt for meget. Du tjener kun " + moneyEarned + " kr.");
        }
        else
        {
            moneyEarned = 0; 
            Debug.Log("For mange ridser! Kunden opdager det, og du får ingenting.");
        }
    }
}
