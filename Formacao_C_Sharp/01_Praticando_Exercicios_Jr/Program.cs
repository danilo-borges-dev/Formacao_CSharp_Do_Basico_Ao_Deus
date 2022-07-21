using System.Text.RegularExpressions;

//ReverseString();
//SumChar();
//HammingDistance();
//WordTotal();
CNumbers();

// Inverta a string dedicacao
void ReverseString()
{
    string text = "dedicacao";
    string result = "";

    for (int i = text.Length; i > 0; i--)
    {
        result += text[i -1];
    }

    Console.WriteLine($"String ao contrário {result}");
}

// Conte quantas vezes se repete o caractere "a" em uma string
void SumChar()
{
    string text = "amacenheu peguei a viola e fui trabalhar";
    int result = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == 'a')
        {
            result++;
        }
    }

    Console.WriteLine($"Número total de caracates a = {result}");

    text = text.ToLower();
    result = text.Where(c => c == 'a').Count();

    Console.WriteLine($"Número total de caracates a = {result}");
}

// Distancia de Hamming
void HammingDistance()
{
    string a = "galinha";
    string b = "gatinha";
    int result = 0;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != b[i])
        {
            result++;
        }
    }

    Console.WriteLine("As duas strings se diferenciam um total de " + result + " caracteres.");
}

// Contar palavras em uma string
void WordTotal()
{
    string stringText = "   para o brasil não existe para tamanho satisfacao para    totalpara    ";
    int result = 0;

    string pattern = @"\s+"; // Expressão regular que vai mapear locais onde se tem dois ou mais espaços

    stringText = stringText.Trim();  // Remove os espaços em branco nas extremidades das strings

    stringText = Regex.Replace(stringText, pattern, " ");  // Recebe a string no primeiro parâmetro e então substitui dois ou mais espaços por apenas um espaço

    var words = stringText.Split();  // Cria um array de string separando as palavras, cada palavra em uma indice diferente
    Console.WriteLine(words[0]);

    result = words.Length; // Conta o total de indices do array

    Console.WriteLine("Total de Palavras " + result);
}

// Contar total de números em uma string
void CNumbers()
{
    string text = " adasd458Adasd-agasdv21154dasdafaspopio-AmPMpasasdkjdu9852 asd sadfasdas1dasrqwfc";
    int result = 0;

    text = text.Trim();
    text = Regex.Replace(text, @"\s+", "");

    result = Regex.Matches(text, "[0-9]").Count;

    Console.WriteLine("Número Total de Números: " + result);

    Console.WriteLine("\n----------------------------------------------\n");

    // Total de Letras
    result = Regex.Matches(text, "[a-zA-z]").Count;
    Console.WriteLine("Total de letras: " + result);
}