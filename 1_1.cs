class Weapon
{
    private int _damage;
    readonly int Bullets;

    public bool TryFire(Player player)
    {
        if (Bullets > 0)
        {
            player.GetDamage(_damage);
            Bullets -= 1;
            return true;
        }
        else
        {
            return false;
        }
    }
}    

class Player
{
    readonly int Health;

    public void GetDamage(int Damage)
    {
        Health -= Damage;
    }
}

class Bot
{
    private Weapon _weapon;

    public void OnSeePlayer(Player player)
    {
            _weapon.TryFire(player);
    }
}
