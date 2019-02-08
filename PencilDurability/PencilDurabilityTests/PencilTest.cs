using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PencilDurability;

namespace PencilDurabilityTests
{
    [TestClass]
    public class PencilTest
    {
        [TestMethod]
        public void WhenTextIsWrittenItIsAppendedToExistingText()
        {
            var text = "the existing text";
            var newText = " the new text.";
            var pencil = new Pencil(50);
            pencil.Write(text);
           var paper = pencil.Write(newText);
            Assert.AreEqual(paper, text + newText);
        }

        [TestMethod]
        public void WhenTextIsWrittenThePencilDulls()
        {
            var pencilDurability = 22;
            var pencil = new Pencil(pencilDurability);
            var text = "the existing text.";
            var newText = "the new text";
            var paper = pencil.Write(text);
            paper = pencil.Write(newText);
            Assert.AreEqual(paper, text + "the new     ");
        }

        [TestMethod]
        public void WhenACapitalLetterIsUsedPencilIsDegradedBy2()
        {
            var pencilDurability = 22;
            var pencil = new Pencil(pencilDurability);
            var text = "The Existing text.";
            var newText = "The new text";
            var paper = pencil.Write(text);
            paper = pencil.Write(newText);
            Assert.AreEqual(paper, text + "The         ");
        }

        [TestMethod]
        public void WhenATheresNotEnoughDurabilityForACapitalLetterThenPrintsASpace()
        {
            var pencilDurability = 22;
            var pencil = new Pencil(pencilDurability);
            var text = "The Existing text.";
            var newText = "ThE new text";
            var paper = pencil.Write(text);
            paper = pencil.Write(newText);
            Assert.AreEqual(paper, text + "Th  n       ");
        }
    }
}
