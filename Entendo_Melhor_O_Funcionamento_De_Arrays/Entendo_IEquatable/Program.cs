using Entendo_IEquatable;

var animais = new List<Animal>()
{
    new Animal("Jacaré", "Réptil"),
    new Animal("Tucano", "Ave"),
    new Animal("Baleia", "Mamífero")
};

var novoAnimal = new Animal("Jacaré", "Réptil");

var contem = animais.Contains(novoAnimal); 
// Existe algum objeto instanciado na lista de animais com as mesmas propriedades de novoAnial,
// ou seja, existe dois objetos com referências diferentes porém com valores iguais?  

Console.WriteLine(contem);