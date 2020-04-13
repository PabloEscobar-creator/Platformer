using Godot;
using System;

public class Actor : KinematicBody2D
{
     public Vector2 velocity = new Vector2();
     [Export]
     public float speed = 200;
         
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
