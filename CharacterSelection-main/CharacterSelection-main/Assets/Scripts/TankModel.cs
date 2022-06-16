using UnityEngine;

public class TankModel 
{
    private TankController tankController;

    public float movement;
    public float rotation;

    public TankModel(float _movement, float _rotation)    //constructor
    {
        movement = _movement;
        rotation = _rotation;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
