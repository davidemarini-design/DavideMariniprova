using UnityEngine;

public class MouseClick : MonoBehaviour
{
private int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void ButtonPressed()
{
    n++;
Debug.Log($"Button pressed: {n}");
    }
}
