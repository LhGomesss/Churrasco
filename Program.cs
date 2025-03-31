// ITEM         ADULTO          CRIANÇAS
// CARNE        500g            150g
// ACOMP.       250g            50g
// CERVEJA      1l              0l
// REFRI        300ml           1l
// ÁGUA         600ml           1,5l

int adultossa,adultosca,crianças,adultos,totalpessoas;
double carne,acompanhamento,cerveja,refrigerante,água;

Console.WriteLine("Digite a quantidade de adultos que consomem bebidas alcoólicas que estarão no churrasco");
adultosca=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de adultos que não consomem bebidas alcoólicas que estarão no churrasco");
adultossa=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de crianças que estarão no churrasco");
crianças=Convert.ToInt32(Console.ReadLine());



adultos=adultosca+adultossa;
totalpessoas=adultos+crianças;


carne=(adultossa*0.5)+(adultosca*0.5)+(crianças*0.15);
acompanhamento=(adultossa*0.25)+(adultosca*0.25)+(crianças*0.05);
cerveja=adultosca*1;
refrigerante=(adultossa*0.3)+(adultosca*0.3)+(crianças*1);
água=(adultossa*0.6)+(adultosca*0.6)+(crianças*1.5);



Console.WriteLine("<3Churras do bigas<3");
Console.WriteLine("");
Console.WriteLine($"Adultos que consomem bebidas alcoólicas:{adultosca}");
Console.WriteLine($"Adultos que não consomem bebidas alcoólicas:{adultossa}");
Console.WriteLine($"Crianças:{crianças}");
Console.WriteLine();
Console.WriteLine($"Carne:{carne}Kg");
Console.WriteLine($"Acompanhamento:{acompanhamento}Kg");
Console.WriteLine($"Cerveja:{cerveja}L");
Console.WriteLine($"Refrigerante:{refrigerante}L");
Console.WriteLine($"Água:{água}L");


