using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    [SerializeField]
    internal Player_Input_Script input_Script;
    [SerializeField]
    internal Player_Movement_Script movement_Script;

    public enum Movement_Direction
    { 
    Positive = 1,//top //right
    None = 0,    //just dont moving 
    Negative = -1//down //left
    }

    public Movement_Direction vertical_moving;
    public Movement_Direction horizontal_moving;
    public Rigidbody2D rb;
    public Vector2 movement_Vector;//from -1 to 1

    public float movement_Speed = 5f;

}
