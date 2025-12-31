using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class SafeArea : MonoBehaviour
{
    RectTransform rectTransform;
    Rect safeArea;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        AplicarSafeArea();
    }

    void AplicarSafeArea()
    {
        safeArea = Screen.safeArea;

        Vector2 min = safeArea.position;
        Vector2 max = safeArea.position + safeArea.size;

        min.x /= Screen.width;
        min.y /= Screen.height;

        max.x /= Screen.width;
        max.y /= Screen.height;

        rectTransform.anchorMin = min;
        rectTransform.anchorMax = max;
    }
}
