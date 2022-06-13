using UnityEngine;

public class TankModel 
{
    private TankController tankController;

    public TankModel()    //constructor
    {

    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
