using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SDS_CodeChallenge.Tests
{
    [TestClass]
    public class UnitTests
    {
        
        // This test method tests the following items: "+5 Dexterity Vest" and "Elixir of the Mongoose".
        // 'daysPassed', 'sellIn', and 'quality' parameters are passed in to yield an array output of final 'sellIn' and 'quality'
        [TestMethod]    
        public void NormalItems()
        {
            ManagementSystem _normalItemsTest = new ManagementSystem();
            CollectionAssert.AreEquivalent(new int[] { 5 , 15 }, _normalItemsTest.NormalItems(5, 10, 20));
            CollectionAssert.AreEquivalent(new int[] { 0, 2 }, _normalItemsTest.NormalItems(5, 5, 7));
            CollectionAssert.AreEquivalent(new int[] { -15, 0 }, _normalItemsTest.NormalItems(25, 10, 20));
            CollectionAssert.AreEquivalent(new int[] { -20, 0 }, _normalItemsTest.NormalItems(25, 5, 7));
        }

        // This test method tests the following items: "Conjured".
        // 'daysPassed', 'sellIn', and 'quality' parameters are passed in to yield an array output of final 'sellIn' and 'quality'
        [TestMethod]
        public void ConjuredItems()
        {
            ManagementSystem _conjuredItemsTest = new ManagementSystem();
            CollectionAssert.AreEquivalent(new int[] { -2, 0 }, _conjuredItemsTest.ConjuredItems(5, 3, 6));
            CollectionAssert.AreEquivalent(new int[] { -7, 0 }, _conjuredItemsTest.ConjuredItems(10, 3, 6));
            CollectionAssert.AreEquivalent(new int[] { 5, 10 }, _conjuredItemsTest.ConjuredItems(5, 10, 20));
            CollectionAssert.AreEquivalent(new int[] { 0, 0 }, _conjuredItemsTest.ConjuredItems(10, 10, 20));
        }

        // This test method tests the following items: "Aged Brie".
        // 'daysPassed', 'sellIn', and 'quality' parameters are passed in to yield an array output of final 'sellIn' and 'quality'
        [TestMethod]
        public void AgedBrie()
        {
            ManagementSystem _agedBrieTest = new ManagementSystem();
            CollectionAssert.AreEquivalent(new int[] { -3, 5 }, _agedBrieTest.AgedBrie(5, 2, 0));
            CollectionAssert.AreEquivalent(new int[] { 0, 20 }, _agedBrieTest.AgedBrie(10, 10, 10));
            CollectionAssert.AreEquivalent(new int[] { -15, 45 }, _agedBrieTest.AgedBrie(30, 15, 15));
            CollectionAssert.AreEquivalent(new int[] { -45, 50 }, _agedBrieTest.AgedBrie(50, 5, 20));
        }

        // This test method tests the following items: "Backstage passes".
        // 'daysPassed', 'sellIn', and 'quality' parameters are passed in to yield an array output of final 'sellIn' and 'quality'
        [TestMethod]
        public void BackstagePasses()
        {
            ManagementSystem _backstagePassesTest = new ManagementSystem();
            CollectionAssert.AreEquivalent(new int[] { 10, 25 }, _backstagePassesTest.BackstagePasses(5, 15, 20));
            CollectionAssert.AreEquivalent(new int[] { 5, 26 }, _backstagePassesTest.BackstagePasses(5, 10, 15));
            CollectionAssert.AreEquivalent(new int[] { -5, 0 }, _backstagePassesTest.BackstagePasses(10, 5, 20));
            CollectionAssert.AreEquivalent(new int[] { 0, 50 }, _backstagePassesTest.BackstagePasses(15, 15, 20));
        }

        // This test method tests the following items: "Legendary".
        // 'daysPassed' is the only parameter passed in because final 'sellIn' and 'quality' remain constant at 0 and 80,
        // respectively.  NOTE: This test simulates the 'UpdateQuality' method because I omitted "Legendary" items from being
        // exposed to any alteration as the main method executes.
        [TestMethod]
        public void LegendaryItems()
        {
            ManagementSystem _legendaryTest = new ManagementSystem();
            CollectionAssert.AreEquivalent(new int[] { 0, 80 }, _legendaryTest.LegendaryItems(5));
            CollectionAssert.AreEquivalent(new int[] { 0, 80 }, _legendaryTest.LegendaryItems(10));
            CollectionAssert.AreEquivalent(new int[] { 0, 80 }, _legendaryTest.LegendaryItems(20));
            CollectionAssert.AreEquivalent(new int[] { 0, 80 }, _legendaryTest.LegendaryItems(25));
        }
    }
}
