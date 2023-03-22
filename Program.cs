var num1 = 2;
var num2 = 3;
var num3 = -5;
var num4 = 3.5;
var num5 = 4.8;

//SOMMA INTERI
var sommaInteri = CalcoliHelper.IntSum(num1, num2);
Console.WriteLine(sommaInteri);

//SOMMA DOUBLE
var sommaDouble = CalcoliHelper.DoubleSum(num4, num5);
Console.WriteLine(sommaDouble);

//DIFFERENZA INTERI
var differenzaInteri = CalcoliHelper.IntDiff(num1, num2);
Console.WriteLine(differenzaInteri);

//DIFFERENZA DOUBLE
var differenzaDouble = CalcoliHelper.DoubleDiff(num4, num5);
Console.WriteLine(differenzaDouble);

//MOLTIPLICAZIONE INTERI
var moltiplicazioneInteri = CalcoliHelper.IntMult(num1, num2);
Console.WriteLine(moltiplicazioneInteri);

//MOLTIPLICAZIONE DOUBLE
var moltiplicazioneDouble = CalcoliHelper.DoubleMult(num4, num5);
Console.WriteLine(moltiplicazioneDouble);

//VALORE ASSOLUTO INTERO
var valoreAssolutoIntero = CalcoliHelper.IntAbs(num3);
Console.WriteLine(valoreAssolutoIntero);

//VALORE ASSOLUTO DOUBLE
var valoreAssolutoDouble = CalcoliHelper.DoubleAbs(num3);
Console.WriteLine(valoreAssolutoDouble);

//MINIMO INTERI
var minimoInteri = CalcoliHelper.IntMin(num1, num2);
Console.WriteLine(minimoInteri);

//MINIMO DOUBLE
var minimoDouble = CalcoliHelper.DoubleMin(num4, num5);
Console.WriteLine(minimoDouble);

//MASSIMO INTERI
var massimoInteri = CalcoliHelper.IntMax(num1, num2);
Console.WriteLine(massimoInteri);

//MASSIMO DOUBLE
var massimoDouble = CalcoliHelper.DoubleMax(num4, num5);
Console.WriteLine(massimoDouble);

//POTENZA INTERO
var potenzaIntero = CalcoliHelper.IntPow(num1, num2);
Console.WriteLine(potenzaIntero);