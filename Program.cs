﻿var num1 = 2;
var num2 = 3;
var num3 = -5;
var num4 = 2.8;
var num5 = 4.5;

//SOMMA INTERI
var sommaInteri = CalcoliHelper.Sum(num1, num2);
Console.WriteLine(sommaInteri);

//SOMMA DOUBLE
var sommaDouble = CalcoliHelper.Sum(num5, num4);
Console.WriteLine(sommaDouble);

//DIFFERENZA INTERI
var differenzaInteri = CalcoliHelper.Diff(num2, num1);
Console.WriteLine(differenzaInteri);

//DIFFERENZA DOUBLE
var differenzaDouble = CalcoliHelper.Diff(num5, num4);
Console.WriteLine(differenzaDouble);

//MOLTIPLICAZIONE INTERI
var moltiplicazioneInteri = CalcoliHelper.Mult(num1, num2);
Console.WriteLine(moltiplicazioneInteri);

//MOLTIPLICAZIONE DOUBLE
var moltiplicazioneDouble = CalcoliHelper.Mult(num5, num4);
Console.WriteLine(moltiplicazioneDouble);

//VALORE ASSOLUTO INTERO
var valoreAssolutoIntero = CalcoliHelper.Abs(num3);
Console.WriteLine(valoreAssolutoIntero);

//VALORE ASSOLUTO DOUBLE
var valoreAssolutoDouble = CalcoliHelper.Abs(num3);
Console.WriteLine(valoreAssolutoDouble);

//MINIMO INTERI
var minimoInteri = CalcoliHelper.Min(num1, num2);
Console.WriteLine(minimoInteri);

//MINIMO DOUBLE
var minimoDouble = CalcoliHelper.Min(num4, num5);
Console.WriteLine(minimoDouble);

//MASSIMO INTERI
var massimoInteri = CalcoliHelper.Max(num1, num2);
Console.WriteLine(massimoInteri);

//MASSIMO DOUBLE
var massimoDouble = CalcoliHelper.Max(num4, num5);
Console.WriteLine(massimoDouble);

//POTENZA INTERO
var potenzaIntero = CalcoliHelper.Pow(num1, num2);
Console.WriteLine(potenzaIntero);