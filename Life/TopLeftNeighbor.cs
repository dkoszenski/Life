using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TopLeftNeighbor : INeighborCreator
{
    public void GetNeighbor(Cell CurrentCell, Grid CurrentGrid)
    {
        if(CurrentCell._WidthIndex > 0 && CurrentCell._HeightIndex > 0)
        {
            Row row = CurrentGrid.Rows[CurrentCell._HeightIndex - 1];
            Cell cell = row.Cells[CurrentCell._WidthIndex - 1];
            CurrentCell._Neighbors.Add(cell);
        }
        if(CurrentCell._WidthIndex == 0 && CurrentCell._HeightIndex == 0)
        {
            Row row = CurrentGrid.Rows[CurrentGrid.Height - 1];
            Cell cell = row.Cells[CurrentGrid.Width - 1];
            CurrentCell._Neighbors.Add(cell);
        }
    }
}
