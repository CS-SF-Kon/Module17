﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Patterns_P1;

public class Account
{
    // тип учетной записи
    public string Type { get; set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }
}