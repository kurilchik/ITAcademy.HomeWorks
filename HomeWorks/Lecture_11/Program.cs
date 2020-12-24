// Decompiled with JetBrains decompiler
// Type: Lecture_11.Program
// Assembly: Lecture_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2F0C073-AD03-46A2-8B7F-AA7987339BD0
// Assembly location: C:\Users\USER\Desktop\Lecture_11.dll

using Lecture_11.Interfaces;

namespace Lecture_11
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      HouseService houseService = new HouseService();
      SmartHouse smartHouse1 = new SmartHouse();
      smartHouse1.Location = "Minsk";
      SmartHouse smartHouse2 = smartHouse1;
      houseService.AddHouse((Building) smartHouse2);
      Building building = (Building) new SmartHouse();
      building.WelcomeGreeting();
      houseService.AddHouse(building);
      ShoppingCenter shoppingCenter1 = new ShoppingCenter();
      shoppingCenter1.Location = "Vitebsk";
      houseService.AddHouse((Building) shoppingCenter1);
      houseService.GetBuildings();
      IDestroyer destroyer = (IDestroyer) new SmartHouse();
      destroyer.Destroy();
      bool flag = destroyer is SmartHouse;
      SmartHouse smartHouse3 = destroyer as SmartHouse;
      ShoppingCenter shoppingCenter2 = destroyer as ShoppingCenter;
    }
  }
}
