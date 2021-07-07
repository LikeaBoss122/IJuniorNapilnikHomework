class Player
    {
        public int Health { get; private set; }
        public bool Dead { get; private set; }

        public Player(int health)
        {
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            if (damage <= 0)
                throw new InvalidOperationException();
            
            if (!Dead)
            {
                Health -= damage;
                TryDeath();
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
