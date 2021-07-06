class Weapon
    {
        private int Damage;
        readonly int Bullets;

        public bool TryFire(Player player)
        {
            if (Bullets > 0)
            {
                player.GetDamage(Damage);
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
        private Weapon Weapon;

        public void OnSeePlayer(Player player)
        {
            Weapon.TryFire(player);
        }
    }