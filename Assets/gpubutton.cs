using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gpubutton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (componentsDone.Contains(gameObject.name))
        {
            gameObject.SetActive(false);
            isdone = true;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public static HashSet<string> componentsDone = new HashSet<string>();
    
 	public GameObject sceneButton;

	public int scenetoload = -1;

	public static int currentscenetoload = -1;

    public Transform placeholder;
    
    public Transform placeholder2;

    public static bool isAnyComponentOut = false;
    
    public bool isOut = false;

    public bool isdone = false;

    public void reset()
    {
        if (isOut == true)
        {
            isdone = true;
            componentsDone.Add(gameObject.name);
        }
        transform.position = placeholder2.position;
        isOut = false;
        isAnyComponentOut = false;
        sceneButton.SetActive(false);
    }

    public void setvisibilitytrue()
    {
        gameObject.SetActive(true);
    }

    public void setvisibilityfalse()
    {
        gameObject.SetActive(false);
    }
    
    void OnMouseDown()
    {
        if (isOut == true)
        {
            transform.position = placeholder2.position;
            isOut = false;
            isAnyComponentOut = false;
			sceneButton.SetActive(false);
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
			sceneButton.SetActive(true);
			currentscenetoload = scenetoload;
        }
    }
}
