using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData;

public class Car
{
    public string Model { get; }
    public Engine Engine { get; }
    public Cargo Cargo { get; }
    public IReadOnlyCollection<Tire> Tires { get; }

    public Car(string model, Engine engine, Cargo cargo, params Tire[] tires)
    {
        this.Tires = new List<Tire>(tires).AsReadOnly();
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
    }
}