using UnityEngine;

public class gpubutton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public Transform placeholder;
    
    public Transform placeholder2;

    public static bool isAnyComponentOut = false;
    
    public bool isOut = false;
    
    void OnMouseDown()
    {
        if (isOut == true)
        {
            transform.position = placeholder2.position;
            isOut = false;
            isAnyComponentOut = false;
        }

        else if (isOut == false && isAnyComponentOut == true)
        {
        }
        
        else if (isAnyComponentOut == false)
        {
            {
                transform.position = placeholder.position;
            }
            isOut = true;
            isAnyComponentOut = true;
        }
    }
}
