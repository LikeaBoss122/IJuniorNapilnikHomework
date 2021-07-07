class Bot
{
    private Weapon _weapon;

    public Bot(Weapon weapon)
    {
        if(_weapon == null)
            throw new InvalidOperationException()
            
        _weapon = weapon;
    }

    public void OnSeePlayer(Player player)
    {
        if (player == null)
            throw new InvalidOperationException();
        
        if (!player.Dead)
            _weapon.TryFire(player);
    }
}
