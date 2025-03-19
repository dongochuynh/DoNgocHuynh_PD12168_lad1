using UnityEngine;

public class Controll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefabCircle;
    void Start()
    {
        GameObject circle = Instantiate(prefabCircle);
        Destroy(circle, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
