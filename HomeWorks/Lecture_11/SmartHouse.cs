// Decompiled with JetBrains decompiler
// Type: Lecture_11.SmartHouse
// Assembly: Lecture_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2F0C073-AD03-46A2-8B7F-AA7987339BD0
// Assembly location: C:\Users\USER\Desktop\Lecture_11.dll

using Lecture_11.Interfaces;
using System;

namespace Lecture_11
{
  internal class SmartHouse : Building, IDestroyer
  {
    public void Destroy() => Console.WriteLine("Destroyed");

    public override int GetSquare() => 200;

    public override void WelcomeGreeting() => Console.WriteLine("Welcome to Smart House!!!");
  }
}
