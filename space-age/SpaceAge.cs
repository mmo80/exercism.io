using System;

public class SpaceAge
{
    private static double _seconds = 0;
    private readonly double _oneEarthYearInSeconds = 31557600;

    public SpaceAge(int seconds) => _seconds = seconds;

    public double OnEarth() => _seconds / _oneEarthYearInSeconds;
    public double OnMercury() => _seconds / (_oneEarthYearInSeconds * 0.2408467);
    public double OnVenus() => _seconds / (_oneEarthYearInSeconds * 0.61519726);
    public double OnMars() => _seconds / (_oneEarthYearInSeconds * 1.8808158);
    public double OnJupiter() => _seconds / (_oneEarthYearInSeconds * 11.862615);
    public double OnSaturn() => _seconds / (_oneEarthYearInSeconds * 29.447498);
    public double OnUranus() => _seconds / (_oneEarthYearInSeconds * 84.016846);
    public double OnNeptune() => _seconds / (_oneEarthYearInSeconds * 164.79132);
}