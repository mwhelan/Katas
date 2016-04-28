namespace Katas.ConwayGameOfLife.Code
{
    public class LifeRules
    {
        public static CellState GetNewState(CellState currentState, int liveNeighbours)
        {
            if (currentState == CellState.Dead)
            {
                if (liveNeighbours == 3)
                {
                    return CellState.Alive;
                }
                else
                {
                    return currentState;
                }
            }

            if (liveNeighbours < 2)
            {
                return CellState.Dead;
            }

            if (liveNeighbours == 2 || liveNeighbours ==3)
            {
                return CellState.Alive;
            }

            return CellState.Dead;
        }
    }
}
