using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Script : MonoBehaviour
{
    [SerializeField]
    Player_Script player_Script;

    private void Update()
    {
        Moving_Axes_Input(out player_Script.vertical_moving,KeyCode.W,KeyCode.S);
        Moving_Axes_Input(out player_Script.horizontal_moving, KeyCode.D, KeyCode.A);
    }
    public void Moving_Axes_Input(out Player_Script.Movement_Direction axes,KeyCode key_pos,KeyCode key_neg)
    {
        if (Input.GetKey(key_pos))
        {
            axes = Player_Script.Movement_Direction.Positive;
        }
        else if (Input.GetKey(key_neg))
        {
            axes = Player_Script.Movement_Direction.Negative;
        }
        else
        {
            axes = Player_Script.Movement_Direction.None;
        }
    }
}
