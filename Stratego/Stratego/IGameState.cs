﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    interface IGameState
    {
        int GetGameState(int[][] board);
    }
}