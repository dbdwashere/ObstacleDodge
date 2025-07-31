using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
   
    void Start()
    {
        PrintInstruction();
    } 

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction(){
        //oyunu başlattıgında bu yazcak
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects!");
    }
    
    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);

    }


}
