using abstract_ornek;
using System;
Focus focus = new();
Console.WriteLine("******INTERFACE******");
Console.WriteLine(focus.HangiMarkaArac());
Console.WriteLine(focus.KacTekerlektenOlusur());
Console.WriteLine(focus.StandartRengiNe());
Console.WriteLine("************************");

Civic civic = new();
Console.WriteLine(civic.HangiMarkaArac());
Console.WriteLine(civic.KacTekerlektenOlusur());
Console.WriteLine(civic.StandartRengiNe());
Console.WriteLine("************************");

Corolla corolla = new();
Console.WriteLine(corolla.HangiMarkaArac());
Console.WriteLine(corolla.KacTekerlektenOlusur());
Console.WriteLine(corolla.StandartRengiNe());
Console.WriteLine("************************");

Benz benz = new();
Console.WriteLine(benz.HangiMarkaArac());
Console.WriteLine(benz.KacTekerlektenOlusur());
Console.WriteLine(benz.StandartRengiNe());
Console.WriteLine("******ABSTRACT******");

NewFocus newFocus = new();
Console.WriteLine(newFocus.HangiMarkaArac());
Console.WriteLine(newFocus.KacTekerlektenOlusur());
Console.WriteLine(newFocus.StandartRengiNe());
Console.WriteLine("************************");

NewCivic newCivic = new();
Console.WriteLine(newCivic.HangiMarkaArac());
Console.WriteLine(newCivic.KacTekerlektenOlusur());
Console.WriteLine(newCivic.StandartRengiNe());

