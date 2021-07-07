class Bot
{
    private Weapon _weapon;

    public Bot(Weapon weapon)
    {
        if(_weapon != null)
        {
            _weapon = weapon;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public void OnSeePlayer(Player player)
    {
        if (player != null && _weapon != null)
        {
            if (!player.Dead)
            {
                _weapon.TryFire(player);
            }
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}