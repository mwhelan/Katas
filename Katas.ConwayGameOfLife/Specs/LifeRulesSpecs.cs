using FluentAssertions;
using Katas.ConwayGameOfLife.Code;
using NUnit.Framework;

namespace Katas.ConwayGameOfLife.Specs
{
    [TestFixture]
    public class LifeRulesSpecs
    {
        // Any live cell with fewer than two live neighbours dies, as if caused by under-population.
        // Any live cell with two or three live neighbours lives on to the next generation.
        // Any live cell with more than three live neighbours dies, as if by overcrowding.
        // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void LiveCell_LessThanTwoLiveNeighbours_Dies(int liveNeighbours)
        {
            LifeRules
                .GetNewState(CellState.Alive, liveNeighbours)
                .Should().Be(CellState.Dead);
        }

        [Test]
        [TestCase(2)]
        [TestCase(3)]
        public void LiveCell_TwoOrThreeLiveNeighbours_Lives(int liveNeighbours)
        {
            LifeRules
                .GetNewState(CellState.Alive, liveNeighbours)
                .Should().Be(CellState.Alive);
        }

        [Test]
        [TestCase(4)]
        [TestCase(99)]
        public void LiveCell_ThreeOrMoreLiveNeighbours_Lives(int liveNeighbours)
        {
            LifeRules
                .GetNewState(CellState.Alive, liveNeighbours)
                .Should().Be(CellState.Dead);
        }

        [Test]
        public void DeadCell_ThreeLiveNeighbours_Lives()
        {
            LifeRules.GetNewState(CellState.Dead, 3)
                .Should().Be(CellState.Alive);
        }
    }
}
