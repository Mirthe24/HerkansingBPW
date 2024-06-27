using UnityEngine;

public class BlinkingEyesURP : MonoBehaviour
{
    public Renderer eyeRenderer;
    public Color glowColor = Color.red;
    public float blinkInterval = 1f;
    public float blinkDuration = 0.1f;
    private Color originalColor;
    private float timer = 0f;

    void Start()
    {
        if (eyeRenderer == null)
        {
            eyeRenderer = GetComponent<Renderer>();
        }
        originalColor = eyeRenderer.material.GetColor("_EmissionColor");
        InvokeRepeating("Blink", blinkInterval, blinkInterval);
    }

    void Blink()
    {
        StartCoroutine(BlinkCoroutine());
    }

    System.Collections.IEnumerator BlinkCoroutine()
    {
        eyeRenderer.material.SetColor("_EmissionColor", Color.black);
        yield return new WaitForSeconds(blinkDuration);
        eyeRenderer.material.SetColor("_EmissionColor", glowColor);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > blinkInterval)
        {
            Blink();
            timer = 0f;
        }
    }
}
