using Godot;
using System;

public class Actor : KinematicBody2D
{
     Vector2 velocity;
     [Export]
     public Vector2 speed = new Vector2(300, 1000);
         
     [Export] 
     public float gravity = 3000;

     public override void _PhysicsProcess(float delta)
     {
          velocity.y += gravity * delta;
          //if (velocity.y > speed.y)
         // {
           //    velocity.y = speed.y;
         // }
          velocity = MoveAndSlide(velocity);
     }
}
