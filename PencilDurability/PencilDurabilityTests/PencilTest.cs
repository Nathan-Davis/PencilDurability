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
            var pencil = new Pencil();
            pencil.Write(text);
           var paper = pencil.Write(newText);
            Assert.AreEqual(paper, text + newText);
        }
    }
}
