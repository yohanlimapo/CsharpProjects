string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;

for (int i = 0;) {
    if (myString[i]) {
        return true;
    }    
}






















// Console.WriteLine("Qual a sua função? administrador, gerente, ou usuário?");

// string? readResult;
// bool validEntry = false;

// do {
//     readResult = Console.ReadLine().Trim().ToLower();
//     if (readResult == "administrador" || readResult == "gerente" || readResult == "usuário") {
//         Console.WriteLine("Opção válida!");
//         validEntry = true;
//     }
//     else {
//         Console.WriteLine("Função inválida. Favor digitar opção válida!");
//         validEntry = false;
//         continue;        
//     }
// } while (validEntry == false);


























// int value = 0;
// bool validNumber = false;

// Console.WriteLine("Insira um valor inteiro entre 5 e 10");

// do {
//     validNumber = int.TryParse(Console.ReadLine(), out value);
//     if (value >= 5 && value <= 10) {
//         Console.WriteLine("Número válido");
//         validNumber = true;
//     }
//     if (value < 5 || value > 10){
//         Console.WriteLine("Inválido! Insira um valor inteiro entre 5 e 10:");
//         validNumber = false;
//         continue;
//     }
//     if (validNumber == false){
//         Console.WriteLine("Inválido! Tem certeza que isso é um número? Insira um valor inteiro entre 5 e 10");
//         validNumber = false;
//         continue;
//     }
//     else continue;

// } while (validNumber == false);

// Console.WriteLine("Valor de entrada aceito. Parabéns!");