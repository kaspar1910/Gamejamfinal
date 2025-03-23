using UnityEngine;
using UnityEngine.SceneManagement;

public class startcompbutton : MonoBehaviour
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

    public gpubutton[] objectsToReset;
    
    
    public void LoadScene()
    {  foreach (gpubutton obj in objectsToReset)
        {
            obj.reset();
        }
        SceneManager.LoadSceneAsync(gpubutton.currentscenetoload);
    }
}
