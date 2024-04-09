namespace Constructor;

internal class Building
{
    public Building(int etages, int taille)
    {
        _etages = etages;
        _taille = taille;
    }
    public Building(int etages)
    {
        _etages = etages;
        _taille *= etages; // 3 * etages
    }

    public int GetFloorMaxSize() => _taille / _etages;
    public int GetFloorCount() => _etages;
    public int GetSize() => _taille;


    private const int _DefaultTaille = 3;
    private int _etages;
    private int _taille = _DefaultTaille;
}
