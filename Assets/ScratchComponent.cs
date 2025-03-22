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
        
        endTaskButton.gameObject.SetActive(false);
        UpdateMoneyUI();
    }

    public void StartTask()
    {
        taskActive = true;
        scratchCount = 0;
        moneyEarned = 0;
        UpdateMoneyUI();
        
        startTaskButton.gameObject.SetActive(false);
        endTaskButton.gameObject.SetActive(true);
    }

    public void EndTask()
    {
        taskActive = false;
        CalculateReward();
        
        startTaskButton.gameObject.SetActive(true);
        endTaskButton.gameObject.SetActive(false);
    }

    public void OnMouseOver()
    {
        if (taskActive && Input.GetMouseButtonDown(0)) 
        {
            scratchCount++;
            float intensity = (float)scratchCount / maxScratches;
            GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.gray, intensity);
        }
        
    }

    public void CalculateReward()
    {
        if (scratchCount == idealScratches)
            moneyEarned = 100;
        else if (scratchCount < idealScratches)
            moneyEarned = 50;
        else if (scratchCount > idealScratches && scratchCount <= maxScratches)
            moneyEarned = 20;
        else
            moneyEarned = 0;

        Debug.Log("Du tjener: " + moneyEarned + " kr.");
        UpdateMoneyUI();
    }
    public void UpdateMoneyUI()
    {
        moneyText.text = "Money earned: " + moneyEarned +"$";
    }
}
