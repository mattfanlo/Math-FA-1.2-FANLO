using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Pulsating Settings")]
    public float pulseSpeed = 3f;       // how fast the enemy scales
    public float pulseAmount = 0.6f;    // how big the scaling change is
    private Vector3 baseScale;

    [Header("Movement Settings")]
    public float moveSpeed = 2f;        // how fast the enemy moves
    public float moveRange = 3f;        // how far from start point it moves
    private Vector3 startPos;

    [Header("Axis Settings")]
    public bool moveX = true;
    public bool moveY = false;
    public bool moveZ = true;

    void Start()
    {
        baseScale = transform.localScale;
        startPos = transform.position;
    }

    void Update()
    {
        // 🔹 Pulsating scale (breathing effect)
        float scaleOffset = Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;
        transform.localScale = baseScale + Vector3.one * scaleOffset;

        // 🔹 Movement back and forth
        float offset = Mathf.Sin(Time.time * moveSpeed) * moveRange;

        Vector3 move = startPos;
        if (moveX) move.x += offset;
        if (moveY) move.y += offset;
        if (moveZ) move.z += offset;

        transform.position = move;
    }
}
