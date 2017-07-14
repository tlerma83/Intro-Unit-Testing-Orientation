using System;
using Xunit;

namespace TreeFarm.Tests
{
    public class TreeShould
    {
        private Tree _tree;

        public TreeShould()
        {
            _tree = new Tree() { Height = 0.2, Location = "A3", Type = "Oak" };
        }

        [Fact]
        public void ChangeLocation()
        {
            // Given this input to the method
            string newLocation = _tree.Move("B3");

            // We are asserting that the output should be this
            Assert.Equal(newLocation, "B3");

            newLocation = _tree.Move("B1007");

            Assert.Equal(newLocation, "B1007");


        }

        [Fact]
        public void Grow()
        {
            // Given this input to the method
            double newOakHeight = _tree.Grow(0.3);

            // We are asserting that the output should be this
            Assert.Equal(newOakHeight, 0.5);

            // Given this input to the method
            newOakHeight = _tree.Grow(0.2);

            // We are asserting that the output should be this
            Assert.Equal(newOakHeight, 0.7);

            newOakHeight = _tree.Grow(1);
            Assert.Equal(newOakHeight, 1.7);
        }

        [Fact]
        public void TreeType() {
            string newTreeType = "maple";

            Assert.Equal(newTreeType, "maple");
        }
    }
}
