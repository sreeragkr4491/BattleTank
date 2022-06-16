using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    private Rigidbody rb;

    public TankController(TankModel _tankModel,TankView _tankView)   //constructor
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView); ;
        rb = tankView.GetRigidbody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);       
    }

    public void Move(float movement,float moveSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * moveSpeed;
    }

    public void Rotate(float rotation,float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotation * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
