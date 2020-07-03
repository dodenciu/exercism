using System;
using System.Collections.Generic;

public enum Planets
{
    Earth,
    Mercury,
    Venus,
    Mars,
    Jupiter,
    Saturn,
    Uranus,
    Neptune
}

public class SpaceAge
{
    private readonly float _ageInSeconds = 1f;

    private const float EARTH_ORBITAL_SECONDS = 31557600f;

    private readonly Dictionary<Planets, float>  _planetsCoefficients = new Dictionary<Planets, float>() { 
        { Planets.Earth, 1f },
        { Planets.Mercury, 0.2408467f },
        { Planets.Venus, 0.61519726f },
        { Planets.Mars, 1.8808158f },
        { Planets.Jupiter, 11.862615f },
        { Planets.Saturn, 29.447498f },
        { Planets.Uranus, 84.016846f },
        { Planets.Neptune, 164.79132f }
    };

    public SpaceAge(int seconds)
    {
        if (seconds < 1)
            throw new ArgumentOutOfRangeException("Age should be equal or greater than one second");

        _ageInSeconds = seconds;
    }

    public double OnEarth() => _ageInSeconds / _planetsCoefficients[Planets.Earth] / EARTH_ORBITAL_SECONDS;

    public double OnMercury() => _ageInSeconds / _planetsCoefficients[Planets.Mercury] / EARTH_ORBITAL_SECONDS;


    public double OnVenus() => _ageInSeconds / _planetsCoefficients[Planets.Venus] / EARTH_ORBITAL_SECONDS;


    public double OnMars() => _ageInSeconds / _planetsCoefficients[Planets.Mars] / EARTH_ORBITAL_SECONDS;

    public double OnJupiter() => _ageInSeconds / _planetsCoefficients[Planets.Jupiter] / EARTH_ORBITAL_SECONDS;
  

    public double OnSaturn() => _ageInSeconds / _planetsCoefficients[Planets.Saturn] / EARTH_ORBITAL_SECONDS;
  

    public double OnUranus() => _ageInSeconds / _planetsCoefficients[Planets.Uranus] / EARTH_ORBITAL_SECONDS;
    

    public double OnNeptune() => _ageInSeconds / _planetsCoefficients[Planets.Neptune] / EARTH_ORBITAL_SECONDS;
  
}