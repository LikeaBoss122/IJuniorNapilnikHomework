class Weapon
{
    private int _damage;
    private bool _enoughBullets => CurrentBulletsCount > 0;
    private int _allBulletsCount => CurrentBulletsCount + MagazineBulletsCount;
    public int CurrentBulletsCount { get; private set; }
    public int MagazineBulletsCount { get; private set; }
    private int _maxMagazineBullets;
    private int _maxCurrentBullets;

    public Weapon(int damageStart, int bulletsStartCount, int maxMagazineBullets, int maxCurrentBullets)
    {
        if (damageStart <= 0 || bulletsStartCount < 0)
            throw new InvalidOperationException();
        
        _damage = damageStart;
        _maxCurrentBullets = maxCurrentBullets;
        _maxMagazineBullets = maxMagazineBullets;
        CurrentBulletsCount = Math.Min(maxCurrentBullets, bulletsStartCount);
        MagazineBulletsCount = maxCurrentBullets > bulletsStartCount ? 0 : bulletsStartCount - maxCurrentBullets;
    }

    public bool TryFire(Player player)
    {
        if (player == null)
            throw new InvalidOperationException();
        
        if(!_enoughBullets)
            return false;

        player.TakeDamage(_damage);
        CurrentBulletsCount -= 1;
        return true;
    }

    private bool TryReload()
    {
        if (MagazineBulletsCount <= 0 || CurrentBulletsCount == _maxCurrentBullets)
            return false;
            
        if (_maxCurrentBullets < _allBulletsCount)
        {
            MagazineBulletsCount = _allBulletsCount - _maxCurrentBullets;
            CurrentBulletsCount = _maxCurrentBullets;
        }
        else
        {
            CurrentBulletsCount = _allBulletsCount;
            MagazineBulletsCount = 0;
        }
        
        return true;
    }
}
