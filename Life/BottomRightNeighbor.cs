﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BottomRightNeighbor : INeighborCreator
{
    public void GetNeighbor(Cell CurrentCell, Grid CurrentGrid)
    {
        if (CurrentCell._WidthIndex < CurrentGrid.Width - 1 && CurrentCell._HeightIndex < CurrentGrid.Height - 1)
        {
            Row row = CurrentGrid.Rows[CurrentCell._HeightIndex + 1];
            Cell cell = row.Cells[CurrentCell._WidthIndex + 1];
            CurrentCell._Neighbors.Add(cell);
        }
    }
}
