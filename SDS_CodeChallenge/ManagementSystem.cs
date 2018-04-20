using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SDS_CodeChallenge
{
    public class ManagementSystem
    {
        public IList<Item> Items = new List<Item>
        {
        new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
        new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
        new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
        new Item { Name = "Sulfuras", SellIn = 0, Quality = 80 },
        new Item { Name = "Backstage passes", SellIn = 15, Quality = 20 },
        new Item { Name = "Conjured", SellIn = 3, Quality = 6 }
        };

        public void UpdateQuality()
        {
            // Looping through the Items list to update 'SellIn' and 'Quality' values accordingly.
            for (var i = 0; i < Items.Count; i++)
            {
                // Setting rules for '+5 Dexterity Vest' & 'Elixir of the Mongoose'
                if ((Items[i].Name == "+5 Dexterity Vest") || (Items[i].Name == "Elixir of the Mongoose"))
                {
                    if (Items[i].Quality == 0)
                    {
                        Items[i].SellIn -= 1;
                    }
                    else if ((Items[i].Quality > 0) && (Items[i].SellIn <= 0))
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality -= 2;

                        if (Items[i].Quality < 0)
                        {
                            Items[i].Quality = 0;
                        }
                    }
                    else if ((Items[i].Quality > 0) && (Items[i].SellIn > 0))
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality -= 1;
                    }
                }

                // Setting rules for the new product, 'Conjured'
                else if (Items[i].Name == "Conjured")
                {
                    if (Items[i].Quality == 0)
                    {
                        Items[i].SellIn -= 1;
                    }
                    else if ((Items[i].Quality > 0) && (Items[i].SellIn <= 0))
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality -= 4;

                        if (Items[i].Quality < 0)
                        {
                            Items[i].Quality = 0;
                        }
                    }
                    else if ((Items[i].Quality > 0) && (Items[i].SellIn > 0))
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality -= 2;

                        if (Items[i].Quality < 0)
                        {
                            Items[i].Quality = 0;
                        }
                    }
                }

                // Setting rules for 'Aged Brie'
                else if (Items[i].Name == "Aged Brie")
                {
                    if (Items[i].Quality == 50)
                    {
                        Items[i].SellIn -= 1;
                    }
                    else if (Items[i].Quality < 50)
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality += 1;
                    }
                }

                // Setting rules for 'Backstage passes'
                else if (Items[i].Name == "Backstage passes")
                {
                    if (Items[i].SellIn <= 0)
                    {
                        Items[i].Quality = 0;
                        Items[i].SellIn -= 1;
                    }
                    else if ((Items[i].SellIn > 0) && (Items[i].Quality >= 50))
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality = 50;
                    }
                    else if (Items[i].SellIn > 10)
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality += 1;
                    }
                    else if ((Items[i].SellIn > 6) && (Items[i].SellIn <= 10))
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality += 2;

                        if (Items[i].Quality > 50)
                        {
                            Items[i].Quality = 50;
                        }
                    }
                    else if (Items[i].SellIn > 0)
                    {
                        Items[i].SellIn -= 1;
                        Items[i].Quality += 3;

                        if (Items[i].Quality > 50)
                        {
                            Items[i].Quality = 50;
                        }
                    }
                }
            }
        }


        // UNIT TESTING METHODS BELOW //

        // The first method below is used to test "Normal" items.  Examples: "+5 Dexterity Vest" and "Elixir of the Mongoose".
        // 
        // **GENERAL NOTES/EXPLANATION FOR METHODS**
        // 'NormalItems()' is a copy of the first 'if' condition within the main method above, except it takes 3 integer
        // parameters and outputs an integer array of length 2 (where output[0] is the SellIn value after N days passed,
        // and output[1] is the Quality value after N days passed).  
        // The method iterates through the loop a number of times equal to the 'daysPassed' parameter.
        // ***Please run the console application and unit tests in order to compare values to confirm accuracy.***

        public int[] NormalItems(int daysPassed, int sellIn, int quality)
        {
            int[] output = new int[2];

            for (var i = 0; i < daysPassed; i++)
            {
                if (quality == 0)
                {
                    sellIn -= 1;
                }
                else if ((quality > 0) && (sellIn <= 0))
                {
                    sellIn -= 1;
                    quality -= 2;

                    if (quality < 0)
                    {
                        quality = 0;
                    }
                }
                else if ((quality > 0) && (sellIn > 0))
                {
                    sellIn -= 1;
                    quality -= 1;
                }
                output[0] = sellIn;
                output[1] = quality;
            }
            return output;
        }

        // Method used to test "Conjured" items.
        public int[] ConjuredItems(int daysPassed, int sellIn, int quality)
        {
            int[] output = new int[2];

            for (var i = 0; i < daysPassed; i++)
            {
                if (quality == 0)
                {
                    sellIn -= 1;
                }
                else if ((quality > 0) && (sellIn <= 0))
                {
                    sellIn -= 1;
                    quality -= 4;

                    if (quality < 0)
                    {
                        quality = 0;
                    }
                }
                else if ((quality > 0) && (sellIn > 0))
                {
                    sellIn -= 1;
                    quality -= 2;

                    if (quality < 0)
                    {
                        quality = 0;
                    }
                }
                output[0] = sellIn;
                output[1] = quality;
            }
            return output;
        }

        // Method used to test "Aged Brie"
        public int[] AgedBrie(int daysPassed, int sellIn, int quality)
        {
            int[] output = new int[2];

            for (var i = 0; i < daysPassed; i++)
            {
                if (quality == 50)
                {
                    sellIn -= 1;
                }
                else if (quality < 50)
                {
                    sellIn -= 1;
                    quality += 1;
                }
                output[0] = sellIn;
                output[1] = quality;
            }
            return output;
        }

        // Method used to test "Backstage Passes"
        public int[] BackstagePasses(int daysPassed, int sellIn, int quality)
        {
            int[] output = new int[2];

            for (var i = 0; i < daysPassed; i++)
            {
                if (sellIn <= 0)
                {
                    quality = 0;
                    sellIn -= 1;
                }
                else if ((sellIn > 0) && (quality >= 50))
                {
                    sellIn -= 1;
                    quality = 50;
                }
                else if (sellIn > 10)
                {
                    sellIn -= 1;
                    quality += 1;
                }
                else if ((sellIn > 6) && (sellIn <= 10))
                {
                    sellIn -= 1;
                    quality += 2;

                    if (quality > 50)
                    {
                        quality = 50;
                    }
                }
                else if (sellIn > 0)
                {
                    sellIn -= 1;
                    quality += 3;

                    if (quality > 50)
                    {
                        quality = 50;
                    }
                }
                output[0] = sellIn;
                output[1] = quality;
            }
            return output;
        }

        // Method used to test "Legendary" items. NOTE: Legendary items do not have to be sold by a certain date
        // and their quality stays fixed at '80'.
        public int[] LegendaryItems(int daysPassed)
        {
            int[] output = new int[2];

            const int legendSellIn = 0;
            const int legendQuality = 80;

            output[0] = legendSellIn;
            output[1] = legendQuality;

            return output;
        }
    }
}

