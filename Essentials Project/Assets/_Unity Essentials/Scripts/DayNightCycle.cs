using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Duration of a full day in seconds
    [Tooltip("Duration of a full day in seconds")]
    public float dayDuration = 120f; // Default to 2 minutes

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation step for this frame
        float rotationStep = (360f / dayDuration) * Time.deltaTime;

        // Rotate the light around the X-axis
        transform.Rotate(Vector3.right, rotationStep);
    }
}
