using UnityEngine;
using TMPro;

public class CounterIncrement : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    int counter;

    public void HandleClick(){
        counter++;
        counterText.text = counter + "";
    }

}
