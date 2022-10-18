using Estudo_C_.Models;
String aplicativo = " ";
Smartphone? celular = null;

while(true){
    Console.WriteLine("Escolha um celular : \n1 - Nokia\n2 - Iphone");
    decimal escolha = Convert.ToDecimal(Console.ReadLine());
    
    if(escolha == 1){
        celular = new Nokia("1282187499", "Nokia v.10", "111111", 32);
        aplicativo = "Whatsaap";
        break;
    } else if(escolha == 2){
        celular = new Iphone("12981941402", "Iphone v.13", "222222", 128);
        aplicativo = "Telegram";
        break;
    }else{
        Console.WriteLine("Por favor escolha uma opção correta!!");
    }
}

  celular.Ligar();
  celular.ReceberLigacao();
  celular.InstalarAplicativo(aplicativo);