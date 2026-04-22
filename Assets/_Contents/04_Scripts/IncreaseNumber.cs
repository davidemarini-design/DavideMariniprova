using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncreaseNumber : MonoBehaviour
{
    public int number = 0;

    public TextMeshProUGUI numberText;

    public void Increase()
    {
        number++;
        UpdateText();
    }

    void UpdateText()
    {
        numberText.text = number.ToString();
    }
}