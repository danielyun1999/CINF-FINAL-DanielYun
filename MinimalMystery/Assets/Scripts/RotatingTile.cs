using UnityEngine;

public class RotatingTile : MonoBehaviour
{
    private RectTransform rectTransform;
    private float correctAngle = 0f;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        // Set correct angle by name
        switch (gameObject.name)
        {
            case "Tile1": correctAngle = 180f; break;
            case "Tile2": correctAngle = 180f; break;
            case "Tile3": correctAngle = 180f; break;
            case "Tile4": correctAngle = 90f; break;
        }
    }

    public void RotateClockwise()
    {
        rectTransform.Rotate(0, 0, -90f);
        FindObjectOfType<PuzzleChecker>().CheckPuzzle();
    }

    public bool IsCorrect()
    {
        float rawAngle = rectTransform.eulerAngles.z;
        float roundedAngle = Mathf.Round(rawAngle / 90f) * 90f % 360f;
        float expectedAngle = ((correctAngle % 360) + 360) % 360;

        Debug.Log($"{gameObject.name} rotation: {roundedAngle}¡Æ (Expected: {expectedAngle}¡Æ)");

        return Mathf.Approximately(roundedAngle, expectedAngle);
    }
}
