using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Script : MonoBehaviour
{
    [SerializeField]
    Player_Script player_Script;

    private void FixedUpdate()
    {
        player_Script.movement_Vector.x = (int)player_Script.horizontal_moving;
        player_Script.movement_Vector.y = (int)player_Script.vertical_moving;
        player_Script.movement_Vector = Vector2.ClampMagnitude(player_Script.movement_Vector, 1);//to avoid increased diagonal movement
        player_Script.rb.MovePosition(player_Script.rb.position + player_Script.movement_Vector * player_Script.movement_Speed * Time.deltaTime);//physical movement
    }
}
