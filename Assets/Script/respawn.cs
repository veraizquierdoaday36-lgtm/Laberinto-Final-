using Unity.VisualScripting;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject puntito;
   private void OnTriggerEnter(Collider other)
    {
        other.transform.position = puntito.transform.position;
    }
}
