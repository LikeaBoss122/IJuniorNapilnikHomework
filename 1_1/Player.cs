class Player
    {
        public int Health { get; private set; }
        public bool Dead => Health <= 0;

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
            }
            
            if (Health <= 0)
            {
                Health = 0;
            }
        }
    }
