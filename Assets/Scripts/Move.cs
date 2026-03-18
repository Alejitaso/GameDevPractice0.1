using Unity.Burst.Intrinsics;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        PrintInstruction();
    }

    void Update()
    {
        MovePlayer();
    }   

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move using WASD or Arrow Keys");
        Debug.Log("Don't touch the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxisRaw("Horizontal");
        float zValue = Input.GetAxisRaw("Vertical");
        

        bool isMoving = (Mathf.Abs(xValue) > 0.1f || Mathf.Abs(zValue) > 0.1f);

        animator.SetBool("isWalking", isMoving);


        transform.Translate(xValue * Time.deltaTime * moveSpeed, 0, zValue * Time.deltaTime * moveSpeed, Space.World);
    }
}
