using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeLookOut = 2f;

    MeshRenderer myMeshRenderer;
    
    Rigidbody myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();
        
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
        
    }

    void Update()
    {
       if (Time.time > timeLookOut)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
