using Godot;
using System;

public partial class Teleporter : Node2D
{
	[Export] public Teleporter teleport_to;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
		{
		}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
