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
            var text = "The Existing text";
            var newText = " The new text.";
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
            var text = "The existing text.";
            var newText = "The new text";
            var paper = pencil.Write(text);
            paper = pencil.Write(newText);
            Assert.AreEqual(paper, text + "The new     ");
        }
    }
}
