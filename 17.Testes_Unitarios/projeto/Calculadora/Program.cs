﻿using Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 10;
int num2 = 20;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");