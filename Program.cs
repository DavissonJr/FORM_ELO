//// 1 - Solicite ao usuário a velocidade de um carro e exiba se ele foi multado.
//// Considere a velocidade máxima permitida de 80 km/h.
//// Se o motorista estiver acima da velocidade exiba uma mensagem informando que ele foi multado.
//// Nesse caso, exiba o valor da multa, cobrando R$ 7,00 por km acima da velocidade permitida.



//try
//{
//    int limite = 80;
//    int multa = 7;


//    Console.WriteLine("Insira a velocidade do carro: ");
//    var velocidadeInserida = Console.ReadLine();
//    // verificando a tipo de dado pelo usuario
//    if (!int.TryParse(velocidadeInserida, out var velocidade))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número inteiro válido.");
//    }
//    if (velocidade < 0)
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número inteiro maior do que zero.");
//    }
//    // condicoes de multa
//    if (velocidade > limite)
//    {
//        multa = (velocidade - limite) * multa;
//        Console.WriteLine($"Você foi multado! O valor da multa é: R$ {multa}");
//    }
//    else
//    {
//        Console.WriteLine("Você não foi multado!");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//// 2 - Solicite ao usuário um número e exiba se ele é par ou ímpar.



//try
//{
//    Console.WriteLine("Insira o número a ser verificado: ");
//    var numero = Console.ReadLine();

//    //verificando a tipo de dado inserido pelo usuario

//    if (!int.TryParse(numero, out var numeroConvertido)) // entra o valor inserido e sai o valor convertido
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número inteiro válido.");
//    }
//    //condicoes de par ou impar
//    if (numeroConvertido % 2 == 0)
//    {
//        Console.WriteLine("O número é par!");
//    }
//    else
//    {
//        Console.WriteLine("O número é ímpar!");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}





//// 3 - Sistema de Avaliação Escolar

//// Solicite ao usuário a nota de um aluno e exiba a sua situação.



//using System.Globalization;

//try
//{
//    Console.WriteLine("Insira a nota do aluno: ");
//    var entrada = Console.ReadLine();

//    // verificando a tipo de dado dado pelo usuario 

//    if (!double.TryParse(entrada, new CultureInfo("ENG"), out var nota))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número válido");
//    }
//    if (nota < 0 || nota > 10)
//    {
//        throw new Exception("Nota inválida! Por favor, insira um número entre 0 e 10.");
//    }
//    // condicoes de avaliacao
//    if (nota < 5)
//    {
//        Console.WriteLine($"Reprovado sua nota é: {nota}");
//    }
//    else if (nota >= 5 && nota <= 6.9)
//    {
//        Console.WriteLine($"Recuperação sua nota é: {nota}");
//    }
//    else
//    {
//        Console.WriteLine($"Aprovado, sua nota é: {nota}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



//// 4 - Verificar ano bissexto

//try
//{
//    Console.WriteLine("Insira o ano a ser verificado: ");
//    // verifica se o dado é inteiro
//    if (!int.TryParse(Console.ReadLine(), out var ano))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número inteiro válido.");
//    }
//    // verifica se o ano é menor que zero
//    if (ano <= 0)
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um ano inteiro válido.");
//    }

//    //verifica se o ano é bissexto

//    if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
//    {
//        Console.WriteLine("O ano é bissexto!");
//    }
//    else
//    {
//        Console.WriteLine("O ano não é bissexto!");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



//// 5 - Crie um programa que leia uma temperatura e classifique-a da seguinte forma:
//// - 0: Congelante 
//// Entre 0°C e 15°C: "Frio".
//// Entre 16°C e 30°C: "Agradável".
//// Entre 31°C e 40°C: "Quente".
//// Acima de 40°C: "Muito quente, cuidado!"

//internal class Program
//{
//    private static void Main(string[] args)
//    {


//        try
//        {
//            Console.WriteLine("Insira a temperatura em graus Celsius: ");
//            var tempInserida = Console.ReadLine();
//            // verificando o dado inserido pelo usuario
//            if (!int.TryParse(tempInserida, out var temperatura))
//            {
//                throw new Exception("Entrada inválida! Por favor, insira um número inteiro válido.");
//            }
//            // chamada do metodo de validacao
//            ValidarTemp(temperatura);
//            // condicoes de temperatura
//            if (temperatura < 0)
//            {
//                Console.WriteLine("Congelante");
//            }
//            else if (temperatura > 0 && temperatura < 15)
//            {
//                Console.WriteLine("Frio");
//            }
//            else if (temperatura > 15 && temperatura < 30)
//            {
//                Console.WriteLine("Agradável");
//            }
//            else if (temperatura > 30 && temperatura < 40)
//            {
//                Console.WriteLine("Quente");
//            }
//            else
//            {
//                Console.WriteLine("Muito quente, cuidado!");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }

//        //metodo de validacao de temperatura, retornando exception dependendo do caso

//        static void ValidarTemp(int temperatura)
//        {
//            if (temperatura < -100)
//            {
//                throw new Exception("Entrada inválida! Por favor, informe uma tempatura entre -100 e 100 válido.");
//            }
//            if (temperatura > 100)
//            {
//                throw new Exception("Entrada inválida! Por favor, informe uma tempatura entre -100 e 100 válido.");
//            }

//        }
//    }
//}





/// 6 - Crie um programa que determine se um usuário pode acessar uma área restrita. 

//Requisitos:

//Solicite a idade do usuário e sua ocupação (opções: "Estudante", "Trabalhador", "Aposentado").
//// 2 readline/variaveis -> idade e ocupação
//Regras de acesso:
//Estudantes só podem acessar se tiverem entre 18 e 25 anos.
//Trabalhadores podem acessar se tiverem entre 25 e 60 anos.
//Aposentados têm acesso irrestrito, independentemente da idade.

//Caso o usuário não atenda aos critérios, exiba uma mensagem personalizada explicando o motivo do bloqueio.*/


//try
//{
//    Console.WriteLine("Insira a idade do usuário: ");
//    var idade = Console.ReadLine();
//    Console.WriteLine("Insira a ocupação do usuário (Estudante, Trabalhador, Aposentado): ");
//    var ocupacao = Console.ReadLine();
//    if (!int.TryParse(idade, out var idadeConvertida))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número inteiro válido.");
//    }
//    if (ocupacao != "Estudante" && ocupacao != "Trabalhador" && ocupacao != "Aposentado")
//    {
//        throw new Exception("Entrada inválida! Por favor, insira uma ocupação válida.");
//    }
//    // chamada do metodo de validacao de acesso
//    ValidarAcesso(idadeConvertida, ocupacao);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
////metodo de validacao de acesso
//static void ValidarAcesso(int idade, string ocupacao)
//{
//    if (ocupacao == "Estudante" && (idade < 18 || idade > 25))
//    {
//        Console.WriteLine("Acesso negado! Estudantes só podem acessar se tiverem entre 18 e 25 anos.");
//    }
//    else if (ocupacao == "Trabalhador" && (idade < 25 || idade > 60))
//    {
//        Console.WriteLine("Acesso negado! Trabalhadores podem acessar se tiverem entre 25 e 60 anos.");
//    }
//    else
//    {
//        Console.WriteLine("Acesso permitido!");
//    }
//}


///*
// Questão 7: Gerenciador de Fila de Atendimento
//Crie um programa que simule uma fila de atendimento de clientes com as seguintes regras:

//O programa deve atribuir um nível de prioridade aos clientes:

//Alta prioridade: Clientes com mais de 70 anos ou com deficiência (informado pelo usuário).
//Média prioridade: Clientes entre 60 e 70 anos.
//Baixa prioridade: Clientes com menos de 60 anos.

//Use estruturas condicionais para classificar os clientes e exibir a ordem de atendimento. Exemplo de retorno:

//Cliente com 70 anos tem: Alta prioridade
//Este cliente será atendido imediatamente.
//*/


//try
//{
//    Console.WriteLine("Insira a idade do cliente: ");
//    var idade = Console.ReadLine();
//    // verifica se a idade foi inserida corretamente
//    if (!int.TryParse(idade, out var idadeConvertida))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número inteiro válido.");
//    }
//    Console.WriteLine("O cliente possui alguma deficiência? (S/N): ");
//    var deficiencia = Console.ReadLine();

//    // verifica se a deficiencia foi inserido corretamente
//    if (deficiencia != "S" && deficiencia != "N")
//    {
//        throw new Exception("Entrada inválida! Por favor, insira uma resposta válida.");
//    }
//    // condicoes de prioridade
//    if (idadeConvertida > 70 || deficiencia == "S")
//    {
//        Console.WriteLine("Alta prioridade");
//        Console.WriteLine("Este cliente será atendido imediatamente.");
//    }
//    else if (idadeConvertida >= 60 && idadeConvertida <= 70)
//    {
//        Console.WriteLine("Média prioridade");
//        Console.WriteLine("Este cliente será atendido em seguida.");
//    }
//    else
//    {
//        Console.WriteLine("Baixa prioridade");
//        Console.WriteLine("Este cliente será atendido por último.");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

///*
//8 - IMC
//Crie um programa que solicita ao usuário seu peso (kg) e altura (m) e calcula o IMC:

//O Índice de Massa Corporal (IMC) é calculado dividindo o peso em quilos pela altura ao quadrado em metros.

//Classifique a condição do usuário:

//Menor que 18.5 → Abaixo do peso.
//Entre 18.5 e 24.9 → Peso normal.
//Entre 25.0 e 29.9 → Sobrepeso.
//Entre 30.0 e 34.9 → Obesidade grau I.
//Entre 35.0 e 39.9 → Obesidade grau II.
//Maior que 40.0 → Obesidade grau III.
//*/

//using System.Globalization;

//try
//{
//    Console.WriteLine("Insira seu peso em KG: ");
//    var peso = Console.ReadLine();
//    //verificando o dado inserido pelo usuario (peso)
//    if (!double.TryParse(peso, NumberStyles.Any, CultureInfo.InvariantCulture, out var pesoConvertido))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um peso válido.");
//    }
//    if(pesoConvertido < 0)
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um peso válido.");
//    }
//    Console.WriteLine("Insira sua altura em M: ");
//    var altura = Console.ReadLine();
//    // verificando o dado inserido pelo usuario (altura)
//    if (!double.TryParse(altura, NumberStyles.Any, CultureInfo.InvariantCulture, out var alturaConvertido))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira uma altura válida.");
//    }

//    if (alturaConvertido < 0)
//    {
//        throw new Exception("Entrada inválida! Por favor, insira uma altura válido.");
//    }
//    // calculo do imc segundo a fomula peso dividido por altura ao quadrado
//    var imc = pesoConvertido / (alturaConvertido * alturaConvertido);
//    Console.WriteLine($"Seu IMC é: {imc:F2}"); // F2 para formatar o numero
//    // condicoes de classificacao do imc
//    if (imc < 18.5)
//    {
//        Console.WriteLine("Você está abaixo do peso");
//    }
//    if (imc > 18.5 && imc < 24.9)
//    {
//        Console.WriteLine("Peso normal");
//    }
//    if (imc > 25.0 && imc < 29.9)
//    {
//        Console.WriteLine("Sobrepeso");
//    }
//    if (imc > 30 && imc < 34.9)
//    {
//        Console.WriteLine("Obesidade Grau I");
//    }
//    if (imc > 35 && imc < 39.9)
//    {
//        Console.WriteLine("Obesidade Grau II");
//    }
//    if (imc > 40)
//    {
//        Console.WriteLine("Obesidade Grau III");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



//9 - Programa imposto de renda

//até r$ 2.112,00 → isento.
//de r$ 2.112,01 a r$ 2.826,65 → 7,5% sobre o valor que ultrapassar r$ 2.112.
//de r$ 2.826,66 a r$ 3.751,05 → 15% sobre o valor que ultrapassar r$ 2.826,66 + r$ 53,00. 
//de r$ 3.751,06 a r$ 4.664,68 → 22,5% sobre o valor que ultrapassar r$ 3.751,06 + r$ 126,00.
//acima de r$ 4.664,68 → 27,5% sobre o valor que ultrapassar r$ 4.664,68 + r$ 269,00.
// o programa deve calcular o imposto e exibir o salário líquido.


//using System.Globalization;

//try
//{
//    Console.WriteLine("Insira o salário do contribuinte: ");
//    var salario = Console.ReadLine();
//    // verificacao se entrará um double
//    if (!double.TryParse(salario, NumberStyles.Any, new CultureInfo("ENG"), out var salarioConvertido))
//    // NumberStyles.Any, permite a operação de análise reconheça todos os estilos numéricos válidos(int, double, +/-)
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um salário válido.");
//    }
//    // definicao das variaveis
//    double imposto = 0;
//    double salarioLiquido = 0;

//    //verificando o salario do contribuinte

//    if (salarioConvertido < 0)
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um salário válido.");
//    }

//    // condicoes do salario

//    if (salarioConvertido >= 0 && salarioConvertido <= 2111)
//    {
//        Console.WriteLine("Isento");
//        Console.WriteLine($"Salário líquido: {salarioConvertido:F2}");
//        return;
//    }

//    if (salarioConvertido <= 2112)
//    {
//        imposto = 0;
//        salarioLiquido = salarioConvertido;
//    }
//    else if (salarioConvertido > 2112 && salarioConvertido <= 2826.65)
//    {
//        imposto = (salarioConvertido - 2112) * 0.075;
//        salarioLiquido = salarioConvertido - imposto;
//    }
//    else if (salarioConvertido > 2826.65 && salarioConvertido <= 3751.05)
//    {
//        imposto = (salarioConvertido - 2826.65) * 0.15 + 53;
//        salarioLiquido = salarioConvertido - imposto;
//    }
//    else if (salarioConvertido > 3751.05 && salarioConvertido <= 4664.68)
//    {
//        imposto = (salarioConvertido - 3751.05) * 0.225 + 126;
//        salarioLiquido = salarioConvertido - imposto;
//    }
//    else
//    {
//        imposto = (salarioConvertido - 4664.68) * 0.275 + 269;
//        salarioLiquido = salarioConvertido - imposto;

//    }
//    // exibicao e f2 para formatar o numero
//    Console.WriteLine($"Imposto de renda: {imposto:F2}");
//    Console.WriteLine($"Salário líquido: {salarioLiquido:F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//// 10 - Programa que calcula o Seguro de Carro

///*
//Crie um programa que calcula o valor do seguro anual de um carro com base nos seguintes critérios:

//Idade do condutor: 
//Menos de 25 anos → Acréscimo de 20%. 
//Entre 25 e 40 anos → Acréscimo de 10%.
//Mais de 40 anos → Sem acréscimo.

//Tempo de carteira de motorista:
//Menos de 2 anos → Acréscimo de 30%.
//Entre 2 e 5 anos → Acréscimo de 15%.

//Histórico de acidentes:
//Nenhum acidente → Desconto de 10%.
//1 acidente → Sem alteração.
//Mais de 1 acidente → Acréscimo de 50%.
//Exiba o valor final do seguro após aplicar todas as regras.
//*/


//using System.Globalization;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        try
//        {
//            Console.WriteLine("Informe o valor base do seguro: ");
//            var seguroBase = Console.ReadLine();
//            double seguro = ValidarEntradaSeguro(seguroBase, "valor base do seguro");
//            // seguro base primeiro paramentro, segundo parametro será (mensagem) no metodo
//            Console.WriteLine("Insira a idade do condutor: ");
//            var idadeInserida = Console.ReadLine();
//            int idade = ValidarIdade(idadeInserida);

//            Console.WriteLine("Insira o tempo de carteira de motorista: ");
//            var tempoCarteira = Console.ReadLine();
//            int tempoCarteiraConvertido = ValidarTempoCarteira(tempoCarteira, idade); // idade como parametro para verificar se o tempo de carteira é menor que a idade

//            Console.WriteLine("Insira o número de acidentes: ");
//            var acidentes = Console.ReadLine();
//            int acidentesConvertidos = ValidarEntradaInt(acidentes, "número de acidentes");
//            //(mensagem)

//            double fator = CalcularFator(idade, tempoCarteiraConvertido, acidentesConvertidos);

//            Console.WriteLine($"O valor do seguro é: {seguro * fator:F2}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//    //metodo para validar idade
//    private static int ValidarIdade(string idadeInserida)
//    {
//        if (!int.TryParse(idadeInserida, out var idade))
//        {
//            throw new Exception("Entrada inválida! Por favor, insira uma idade válida.");
//        }
//        if (idade < 0)
//        {
//            throw new Exception("Entrada inválida! Por favor, insira um número inteiro maior do que zero.");
//        }
//        if (idade < 18)
//        {
//            throw new Exception("Entrada inválida! Você não pode possuir CNH com menos de 18 anos");
//        }

//        return idade;
//    }

//    //metodo para validar entrada de double
//    private static double ValidarEntradaSeguro(string doubleInserido, string mensagem)
//    {
//        if (!double.TryParse(doubleInserido, NumberStyles.Any, new CultureInfo("ENG"), out var valor))
//        {
//            throw new Exception($"Entrada inválida! Por favor, insira um {mensagem} válido.");
//        }
//        return valor;
//    }

//    //metodo para validar a entrada de inteiros
//    private static int ValidarEntradaInt(string inteiroInserido, string mensagem)
//    {
//        if (!int.TryParse(inteiroInserido, out var valor))
//        {
//            throw new Exception($"Entrada inválida! Por favor, insira uma {mensagem} válida.");
//        }
//        if (valor < 0)
//        {
//            throw new Exception($"Entrada inválida! Por favor, insira um {mensagem} maior ou igual a zero.");
//        }
//        return valor;
//    }

//    //metodo para validar o tempo de carteira de motorista
//    private static int ValidarTempoCarteira(string entrada, int idade)
//    {
//        if (!int.TryParse(entrada, out var valor))
//        {
//            throw new Exception("Entrada inválida! Por favor, insira um tempo de carteira válido.");
//        }
//        // verifica se o tempo de carteira é maior que a idade, isso não pode acontecer
//        if (valor > idade)
//        {
//            throw new Exception("Entrada inválida! O tempo de carteira não pode ser maior que a idade.");
//        }
//        if (valor < 0)
//        {
//            throw new Exception("O tempo de carteira não pode ser menor do que 0");
//        }
//        // verifica se a diferença entre a idade e o tempo de carteira é menor que 18
//        if (idade - valor < 18)
//        {
//            throw new Exception("Insira o tempo de carteira válido! Você não pode ter obtido a carteira com menos de 18 anos.");
//        }
//        return valor;
//    }

//    //metodo p calcular o valor do fator (sera aplicado a multiplicacao)
//    private static double CalcularFator(int idade, int tempoCarteira, int acidentes)
//    {
//        double fator = 1;

//        if (idade < 25)
//        {
//            fator += 0.2;
//        }
//        else if (idade >= 25 && idade <= 40)
//        {
//            fator += 0.1;
//        }

//        if (tempoCarteira < 2)
//        {
//            fator += 0.3;
//        }
//        else if (tempoCarteira >= 2 && tempoCarteira <= 5)
//        {
//            fator += 0.15;
//        }

//        if (acidentes == 0)
//        {
//            fator -= 0.1;
//        }
//        else if (acidentes > 1)
//        {
//            fator += 1.5;
//        }

//        return fator;
//    }
//}


// 11 - Simulador de aprovador de emprestimo

//using System.Globalization;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        try
//        {
//            // variaveis com chamadas de metodo
//            double salario = SolicitarDouble("Insira o salário mensal do usuário: "); //mensagem exibida no metodo abaixo
//            double emprestimo = SolicitarDouble("Insira o valor do empréstimo solicitado: "); //mensagem exibida no metodo abaixo
//            int parcelas = SolicitarInt("Insira o número de parcelas: "); //mensagem exibida no metodo abaixo
//            bool nomeSujo = SolicitarNomeSujo("O usuário tem nome sujo? (S/N): "); //mensagem exibida no metodo abaixo
//            // calculo do valor da parcela 
//            double valorParcela = emprestimo / parcelas;
//            // metodo de validacao de emprestimo e os parametros nele utilizado 
//            ValidarEmprestimo(salario, emprestimo, parcelas, nomeSujo, valorParcela);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//    //metodo para solicitar um double
//    private static double SolicitarDouble(string mensagem) // string mensagem exibe uma mensagem personalizada e
//                                                           // permite que o metodo seja reutilizada onde diferentes mensagens sao chamadas
//    {
//        Console.WriteLine(mensagem);
//        var valorInserido = Console.ReadLine();
//        if (!double.TryParse(valorInserido, NumberStyles.Any, CultureInfo.InvariantCulture, out var valor))
//        {
//            throw new Exception("Entrada inválida! Por favor, insira um valor válido.");
//        }
//        if (valor < 0)
//        {
//            throw new Exception("Entrada inválida! O valor não pode ser menor do que zero.");
//        }
//        return valor;
//    }

//    //metodo para solicitar um inteiro
//    private static int SolicitarInt(string mensagem)
//    {
//        Console.WriteLine(mensagem);
//        var input = Console.ReadLine();
//        // verificando se a entrada é valida
//        if (!int.TryParse(input, out var valor))
//        {
//            throw new Exception("Entrada inválida! Por favor, insira um número válido.");
//        }
//        if (valor < 0)
//        {
//            throw new Exception("Entrada inválida! O valor não pode ser menor do que zero.");
//        }
//        return valor;
//    }

//    private static bool SolicitarNomeSujo(string mensagem)
//    {
//        Console.WriteLine(mensagem);
//        var situacaoNome = Console.ReadLine();
//        //verificando se a entrada é valida
//        if (situacaoNome != "S" && situacaoNome != "N")
//        {
//            throw new Exception("Entrada inválida! Por favor, insira 'S' para sim ou 'N' para não.");
//        }
//        return situacaoNome == "S";
//    }

//    //metodo para executar as condicionais de emprestimo
//    private static void ValidarEmprestimo(double salario, double emprestimo, int parcelas, bool nomeSujo, double valorParcela)
//    {
//        if (nomeSujo)
//        {
//            Console.WriteLine("Empréstimo negado! Usuário com nome sujo.");
//        }
//        else if (salario < 2000 && parcelas <= 12)
//        {
//            Console.WriteLine("Empréstimo negado! Para salários inferiores a R$ 2.000,00, o número de parcelas deve ser maior que 12.");
//        }
//        else if (salario > 10000 && valorParcela > salario * 0.5)
//        {
//            Console.WriteLine("Empréstimo negado! Para salários superiores a R$ 10.000,00, a parcela não pode ser maior que 50% do salário.");
//        }
//        else if (valorParcela > salario * 0.3)
//        {
//            Console.WriteLine("Empréstimo negado! O valor da parcela não pode ultrapassar 30% do salário.");
//        }
//        else
//        {
//            Console.WriteLine("Empréstimo aprovado!");
//        }
//    }
//}


//12 - Ver se é maior de idade ou nao

//try
//{
//    Console.WriteLine("Insira a idade: ");
//    var idadeInserida = Console.ReadLine();

//    //verificando o dado inserido pelo usuario

//    if (!int.TryParse(idadeInserida, out var idade))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira uma idade válida.");
//    }
//    if (idade < 0)
//    {
//        throw new Exception("Entrada inválida! Por favor, insira uma idade válida.");
//    }
//    if (idade >= 18)
//    {
//        Console.WriteLine("Maior de idade");
//    }
//    else
//    {
//        Console.WriteLine("Menor de idade");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

// 13 - Verificar maior numero

//using System.Globalization;

//try
//{
//    //  verificando o dado inserido pelo usuario
//    Console.WriteLine("Insira o primeiro número: ");
//    var primeiroInserido = Console.ReadLine();
//    if (!double.TryParse(primeiroInserido, new CultureInfo("ENG"), out var primeiroNumero))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número válido.");
//    }
//    Console.WriteLine("Insira o segundo número: ");
//    var segundoInserido = Console.ReadLine();
//    if (!double.TryParse(segundoInserido, new CultureInfo("ENG"), out var segundoNumero))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número válido.");
//    }
//    Console.WriteLine("Insira o terceiro número: ");
//    var terceiroInserido = Console.ReadLine();

//    if (!double.TryParse(terceiroInserido, new CultureInfo("ENG"), out var terceiroNumero))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número válido.");
//    }

//    // chamada do metodo e parametros
//    VerificarMaiorNumero(primeiroNumero, segundoNumero, terceiroNumero);
//    VerificarMenorNumero(primeiroNumero, segundoNumero, terceiroNumero);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//// metodo de verificacao de maior numero
//static void VerificarMaiorNumero(double numero1, double numero2, double numero3)
//{
//    if (numero1 > numero2 && numero1 > numero3)
//    {
//        Console.WriteLine($"O maior número é: {numero1}");
//    }
//    else if (numero2 > numero1 && numero2 > numero3)
//    {
//        Console.WriteLine($"O maior número é: {numero2}");
//    }
//    else
//    {
//        Console.WriteLine($"O maior número é: {numero3}");
//    }
//}

//// metodo de verificacao de menor numero
//static void VerificarMenorNumero(double numero1, double numero2, double numero3)
//{
//    if (numero1 < numero2 && numero1 < numero3)
//    {
//        Console.WriteLine($"O menor número é: {numero1}");
//    }
//    else if (numero2 < numero1 && numero2 < numero3)
//    {
//        Console.WriteLine($"O menor número é: {numero2}");
//    }
//    else
//    {
//        Console.WriteLine($"O menor número é: {numero3}");
//    }
//}




// 14 - Desenvolva um programa que pergunte a distancia de uma viagem em km. 
//Calcule o preço da passagem, cobrando R$0.50 por km para viagens de até 200km e R$0.45 para viagens mais longas .

//using System.Globalization;

//try
//{
//    Console.WriteLine("Insira a distancia percorrida em KM: ");
//    var distanciaInserida = Console.ReadLine();
//    // guardando o preco nas variaveis
//    const double precoCurtaDistancia = 0.5;
//    const double precoLongaDistancia = 0.45;

//    //validacao de possiveis erros com o culture info para reconhecer floats

//    if (!double.TryParse(distanciaInserida, new CultureInfo("ENG"), out var distancia))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número válido.");
//    }
//    if (distancia <= 0)
//    {
//        throw new Exception("Entrada inválida! Não existe distância abaixo de zero.");
//    }
//    // if/else em operador ternario por ser uma verificacao simples
//    double preco = distancia <= 200 ? distancia * precoCurtaDistancia : distancia * precoLongaDistancia;
//    string mensagem = $"O preço da passagem é: {preco}";
//    Console.WriteLine(mensagem);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

// 15 - Crie um programa que leia o valor de uma compra e, se o valor for superior a R$ 100
//aplique um desconto de 10% no valor total. Caso contrário, não aplica desconto.

//using System.Globalization;

//try
//{
//    Console.WriteLine("Insira o valor da compra: ");
//    var valorCompra = Console.ReadLine();
//    const double desconto = 0.1;
//    //validacao de possiveis erros com o culture info para reconhecer floats
//    if (!double.TryParse(valorCompra, new CultureInfo("ENG"), out var valor))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um número válido.");
//    }
//    if (valor <= 0)
//    {
//        throw new Exception("Entrada inválida! Infelizmente, nossa loja não possui produtos gratuitos.");
//    }
//    // if/else em operador ternario por ser uma verificacao simples
//    double valorFinal = valor > 100 ? valor - (valor * desconto) : valor;
//    string mensagem = $"O valor final da compra é: {valorFinal}";
//    Console.WriteLine(mensagem);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//16 - Cadastro de Funcionário

//Crie um programa que leia o salário de um funcionário e sua categoria. 

//Se o salário for inferior a R$ 2.000,00, o programa deverá exibir que o funcionário recebe "Salário baixo". 

//Se o salário estiver entre R$ 2.000,00 e R$ 5.000,00, o programa deverá exibir que o funcionário recebe "Salário médio". 
//Caso o salário seja superior a R$ 5.000,00, deverá exibir "Salário alto".

//Além disso, o programa deve validar se a categoria informada pelo usuário está correta. As categorias válidas são "Estagiário", "Júnior", "Pleno" e "Sênior". Caso a categoria não seja uma dessas, o programa deverá exibir uma mensagem de erro.

//Implemente as validações necessárias.

//using System.Globalization;

//try
//{
//    // verificando os dados inserido pelo usuario
//    Console.WriteLine("Insira o valor do seu salário: ");
//    if (!double.TryParse(Console.ReadLine(), new CultureInfo("ENG"), out var salario))
//    {
//        throw new Exception("Entrada inválida! Por favor, insira um salário válido.");
//    }
//    // verificando se salario é maior que 0
//    if (salario < 0)
//    {
//        throw new Exception("Salário inválido! Por favor, insira um salário válido.");
//    }
//    Console.WriteLine("Insira seu cargo: (Estagiário, Júnior, Pleno, Sênior)");
//    var categoria = Console.ReadLine();
//    //metodos de validacao e classificacao
//    ValidarCategoria(categoria);
//    ClassificacaoSalario(salario, categoria); //categoria chamada pra aceitar concatenacao no metodo
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

////metodo de validacao de categoria
//static void ValidarCategoria(string categoria)
//{
//    if (categoria != "Estagiário" && categoria != "Júnior" && categoria != "Pleno" && categoria != "Sênior")
//    {
//        throw new Exception("Categoria inválida! Por favor, insira uma categoria válida.");
//    }
//}

////metodo de classificacao de salario c/ implementacao de contatenacao de categoria

//static void ClassificacaoSalario(double salario, string categoria)
//{
//    if (salario < 2000)
//    {
//        Console.WriteLine($"Você é {categoria} e seu salário é baixo");
//    }
//    else if (salario >= 2000 && salario <= 5000)
//    {
//        Console.WriteLine($"Você é {categoria} e seu salário é médio");
//    }
//    else
//    {
//        Console.WriteLine($"Você é {categoria} e seu salário é alto");
//    }
//}