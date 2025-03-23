using TMPro;
using UnityEngine;

public class hidefront : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        MoneyStartScreen.text = $"Money Scammed: {MoneyTotal} kr";
    }
    
    
    public TextMeshProUGUI MoneyStartScreen;

    public static int MoneyTotal = 0;
    
    public GameObject[] gpuObjectsToEnable;

    public void OnMouseDown()
    {
            gameObject.SetActive(false);
            foreach (GameObject obj in gpuObjectsToEnable)
            {
                gpubutton comp = obj.GetComponent<gpubutton>(); 

                if (comp == null) continue; 

                if (comp.isdone == true)
                {
                    comp.setvisibilityfalse();
                }

                if (comp.isdone == false)
                {
                    comp.setvisibilitytrue();
                }
            }
    }
}
