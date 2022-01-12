using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Item
    {
        ArrayList Dates;
        Double Price;
        String Name;
        Boolean Star;
        public Item() {
            List<int[]> Dates = new List<int[]>();
            Double Price = 0.0;
            String Name = "";
            Boolean Star = false;
        }
        public void UpdateDates(int[][] n)
        {
            Dates.Add(n); Dates.Sort();
        }

        public void SetPrice(double input)
        {
            Price = input;
        }

        public Boolean PredictItem(int[] D)
        {
            int dSize = Dates.Count;
            int[][] Date2 = new int[dSize][]; Date2 = (int[][]) Dates.ToArray();// as int[][];
            int[] diff = new int[dSize-1];
        for (int i = 0; i < dSize - 1; i++)
            {
                diff[i]=(365 * (Date2[i][0] - Date2[i + 1][0]) + 30 * (Date2[i][2] - Date2[i + 1][1]) + Date2[i][2] - Date2[i + 1][2]);
            }
            int med = diff[dSize / 2];
            int IQR = diff[dSize / 4] - diff[(dSize * 3)/4];
            int mean = 0;
            int counter = 0;
            for (int i = 0; i < dSize-1; i++)
            {
                if (!(diff[i] < med - 1.5 * IQR || diff[i] > med + 1.5 * IQR))
                { mean += diff[i]; }
                else { counter++; }
            }
            mean = mean / (dSize-1-counter);
            return ((365 * (Date2[dSize][0] - D[0]) + 30 * (Date2[dSize][2] - D[1]) + Date2[dSize][2] - D[2]) > mean - mean / 7); //there is a mean/7 to give some leeway
        }
    }
}
