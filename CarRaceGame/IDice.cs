﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic;

public interface IDice
{
  public int Dots { get; set; }
  public void Roll();
}