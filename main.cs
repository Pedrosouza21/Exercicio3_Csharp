using System;


   class MainClass {
  public static void Main (string[] args) {
    int n, cont, x;
    string opc;
    do{
      Console.Clear();
      Console.Write("Insira um número: ");
      n = int.Parse(Console.ReadLine());
      for(cont=1;cont<=10; cont++){
        x=  n*cont;
        Console.WriteLine("");
        Console. Write("{0}X{1}={2}", n, cont, x);
      }
      do{
        Console.WriteLine("");
        Console.Write("Pretende continuar ?\n\n1-(S)im\n2-(N)ão\n");
        opc = Console.ReadLine().ToUpper();
        if(opc!="S"&opc!="1"&opc!="N"&opc!="2")
        Console.Write("Opção Inválida\n");
      }
      while(opc!="S"&opc!="1"&opc!="N"&opc!="2");
    }
    while(opc=="S"||opc=="1");
    Console.Write("Fim");
  }
}