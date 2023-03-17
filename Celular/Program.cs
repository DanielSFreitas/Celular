using Celular.models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("C654", "ABC1456", "154315413", 128);
nokia.Liga();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snakerhead");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone("PRO16", "AEA31561", "2454156", 516);
iphone.Liga();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Figma");