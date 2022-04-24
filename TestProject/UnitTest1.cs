using InventoryUpdate;
using Xunit;

namespace TestProject
{
  public class UnitTest1
  {
    [Fact]
    public void Should_Return_An_Matrix_Array()
    {
      Iventory iventory = new Iventory();

      dynamic[][] curInv = new dynamic[][] {
        new dynamic[] { 21, "Bowling Ball" },
        new dynamic[] { 2, "Dirty Sock" },
        new dynamic[] { 1, "Hair Pin" },
        new dynamic[] { 5, "Microphone" }
      };

      dynamic[][] newInv = new dynamic[][] {
        new dynamic[] { 2, "Hair Pin" },
        new dynamic[] { 3, "Half-Eaten Apple" },
        new dynamic[] { 67, "Bowling Ball" },
        new dynamic[] { 7, "Toothpaste" }
      };

      dynamic[] iventoryUpdated = iventory.Update(curInv, newInv);

      Assert.IsType<dynamic[][]>(iventoryUpdated);
      Assert.NotNull(iventoryUpdated);
    }

    [Fact]
    public void Should_Return_An_Array_Length_6()
    {
      Iventory iventory = new Iventory();

      dynamic[][] curInv = new dynamic[][] {
        new dynamic[] { 21, "Bowling Ball" },
        new dynamic[] { 2, "Dirty Sock" },
        new dynamic[] { 1, "Hair Pin" },
        new dynamic[] { 5, "Microphone" }
      };

      dynamic[][] newInv = new dynamic[][] {
        new dynamic[] { 2, "Hair Pin" },
        new dynamic[] { 3, "Half-Eaten Apple" },
        new dynamic[] { 67, "Bowling Ball" },
        new dynamic[] { 7, "Toothpaste" }
      };

      dynamic[] iventoryUpdated = iventory.Update(curInv, newInv);

      Assert.True(iventoryUpdated.Length == 6);
    }
  }
}
