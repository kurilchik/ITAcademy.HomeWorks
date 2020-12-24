// Decompiled with JetBrains decompiler
// Type: Lecture_11.HouseService
// Assembly: Lecture_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2F0C073-AD03-46A2-8B7F-AA7987339BD0
// Assembly location: C:\Users\USER\Desktop\Lecture_11.dll

namespace Lecture_11
{
  internal class HouseService
  {
    private Building[] _buildings = new Building[5];
    private byte _counter;

    public void AddHouse(Building building)
    {
      if (this._counter >= (byte) 5)
        return;
      this._buildings[(int) this._counter] = building;
      ++this._counter;
    }

    public Building[] GetBuildings() => this._buildings;
  }
}
