using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float torqueAmount = 5f;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Rotate(float inputValue)
    {
        rb.AddTorque(inputValue * torqueAmount);
    }
}
