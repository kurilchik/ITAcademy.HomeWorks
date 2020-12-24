// Decompiled with JetBrains decompiler
// Type: Lecture_11.Building
// Assembly: Lecture_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2F0C073-AD03-46A2-8B7F-AA7987339BD0
// Assembly location: C:\Users\USER\Desktop\Lecture_11.dll

using System;

namespace Lecture_11
{
  internal abstract class Building
  {
    private byte _floors = 1;

    public Guid Id { get; private set; } = Guid.NewGuid();

    public byte Floors
    {
      get => this._floors;
      set
      {
        if (value > (byte) 10)
          Console.WriteLine("Please call another Company");
        else
          this._floors = value;
      }
    }

    public string Location { get; set; } = "Default";

    public Building()
    {
    }

    public Building(byte floor) => this.Floors = floor;

    public virtual void WelcomeGreeting() => Console.WriteLine("Hello");

    public abstract int GetSquare();
  }
}
