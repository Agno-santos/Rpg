using Rpg;


Knight arus = new Knight("Arus", 2," knight");
Hero oponent = new Hero("Maleficant",99,"devil");
Wizard wizard = new Wizard("Jennica", 23, "Wizard");
BlackWizard bwizard = new BlackWizard("Mahad",25,"Black Wizard");
Ninja ninja = new Ninja("Gaiden",30,"Ninja");

System.Console.WriteLine(arus.Attack());
System.Console.WriteLine(oponent);
System.Console.WriteLine(wizard.Attack(7));
System.Console.WriteLine(wizard.Attack(1));
System.Console.WriteLine(ninja.Attack());
System.Console.WriteLine(ninja.Attack(3));
System.Console.WriteLine(ninja.Attack(10));
System.Console.WriteLine(bwizard.Attack(2));
System.Console.WriteLine(bwizard.Attack(8));