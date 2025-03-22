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
        
    }

    public GameObject[] gpuObjectsToEnable;

    public void hidefrontbutton()
    {
        // Hide the current object
        gameObject.SetActive(false);

        // Show all assigned GPU objects
        foreach (GameObject gpu in gpuObjectsToEnable)
        {
            gpu.SetActive(true);
        }
    }
}
