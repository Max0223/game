public class ElectricalEngine : Engine
{
    private float _speed = 5f;
    private float _energySpend = 1f;
    private Battery _battery = new Battery();

    public ElectricalEngine(Battery battery, float speed) 
    {
        _speed = speed;
    }

    public override float Speed => _speed;
    
    public override bool TryMove()
    {
        if (_battery.Charge > 0)
        {
            _battery.Spend(_energySpend);
            return true;
        }
        return false;
    }
}
