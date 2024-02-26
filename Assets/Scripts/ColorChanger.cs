using UnityEngine;
using UnityEngine.UI;

public class RandomColorButton : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(HandleClick);
    }

    void HandleClick()
    {
        Color newColor = new(Random.value, Random.value, Random.value);
        button.image.color = newColor;
    }
}
