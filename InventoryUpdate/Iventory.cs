using System;

namespace InventoryUpdate
{
  public class Iventory
  {
    public dynamic[] Update(dynamic[][] curInv, dynamic[][] newInv)
    {
      int newInvOriginalLength = newInv.Length;

      for (int i = 0; i < newInvOriginalLength; i++)
      {
        bool bFind = false;

        for (int j = 0; j < newInvOriginalLength; j++)
        {
          if (newInv[i][1].Equals(curInv[j][1]))
          {
            bFind = true;
            break;
          }
        }

        if (bFind)
        {
          Array.Resize(ref curInv, curInv.Length + 1);
          curInv[newInv.Length] = curInv[i];
        }

      }
      return curInv;
    }
  }
}
