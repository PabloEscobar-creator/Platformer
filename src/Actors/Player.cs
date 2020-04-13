using Godot;
using System;

public class Player : Actor
{
  public Vector2 direction = new Vector2();

    private void GetInput()
    {
       direction.x = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
       direction.y = Input.GetActionStrength("jump")*(gravity*2);
        
    }
     public override void _PhysicsProcess(float delta)
    {
        GetInput();  
        velocity.x = speed*direction.x;
        velocity.y = gravity - direction.y ;
        GD.Print(velocity.y);
        velocity = MoveAndSlide(velocity);
        
    }  
  
}
