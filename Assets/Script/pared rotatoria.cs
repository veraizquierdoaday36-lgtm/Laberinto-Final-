using UnityEngine;

public class paredrotatoria : MonoBehaviour
{
    [SerializeField]
    float rotationY;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotationY * Time.deltaTime, 0f);
    }
}
