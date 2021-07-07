class Player
    {
        public int Health { get; private set; }
        public bool Dead { get; private set; }

        public Player(int health)
        {
            Health = health;
        }

        public void GetDamage(int damage)
        {
            if (damage > 0)
            {
                if (!Dead)
                {
                    Health -= damage;
                    TryDeath();
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        private void TryDeath()
        {
            if (Health <= 0)
            {
                Dead = true;
                Health = 0;
            }
        }
    }
