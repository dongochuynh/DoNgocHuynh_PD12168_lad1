using UnityEngine;

public class TriangleControll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Triangle;
    void Start()
    {
        Triangle = GameObject.FindWithTag("Player");
        //Triangle.SetActive(false);
        Transform haha = Triangle.transform;
        haha.position = Vector2.zero;
        Rigidbody2D rb = haha.GetComponent<Rigidbody2D>();
        rb.mass = 10.0f;
        Destroy(Triangle, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
