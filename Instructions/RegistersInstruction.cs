﻿/*
    Dexer, open source framework for .DEX files (Dalvik Executable Format)
    Copyright (C) 2010 Sebastien LEBRETON

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;
using System.Text;
using Dexer.Core;

namespace Dexer.Instructions
{
    public class RegistersInstruction : Instruction
    {
        public IList<Register> Registers { get; set; }

        public RegistersInstruction(params Register[] registers)
        {
            Registers = new List<Register>(registers);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.ToString());
            builder.Append(" ");
            for (int i = 0; i < Registers.Count; i++)
            {
                if (i > 0)
                    builder.Append(" ");
                builder.Append(Registers[i]);
            }
            return builder.ToString();
        }
    }
}