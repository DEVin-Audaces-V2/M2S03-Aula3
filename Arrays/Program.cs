
int[] num = new int[3];


num[0] = 1;
num[1] = 6;
num[2] = 8;


Console.WriteLine("Posição 0 : " + num[0]);
Console.WriteLine("Posição 1 : " + num[1]);
Console.WriteLine("Posição 2 : " + num[2]);



int tamanhoArray = 2 ;

string[] nomes = new string[tamanhoArray];

for(int i = 0; i< tamanhoArray; i++){
  Console.WriteLine($"Digite o {i} nome:");
  nomes[i] = Console.ReadLine();
}

foreach(var nome in nomes)
{
  Console.WriteLine(nome);
}

///Listas

List<string> lista = new List<string>();
lista.Add("Ovo");
lista.Add("Leite");
lista.Add("Cafe");
lista.Add("Pão");
lista.Add("Agua");
lista.Add("Bolachas");
lista.Remove("Cafe");

string[] arrayFromList = lista.ToArray();

List<string> listFromArray = arrayFromList.ToList();

lista.AddRange(listFromArray);

lista.AddRange(arrayFromList);

lista.Clear();




for(int i = 0; i< lista.Count; i++){
  Console.WriteLine(lista[i]);
}




int tamanhoLista ;

Console.WriteLine("qual o tamanho da lista? ");
string resposta = Console.ReadLine();

if (!int.TryParse(resposta, out tamanhoLista)){
  Console.WriteLine("Valor Inválido");
  return;
}

List<string> nomesLista = new List<string>();

for(int i = 0; i< tamanhoLista; i++){
  Console.WriteLine($"Digite o {i} nome:");
  nomesLista.Add(Console.ReadLine());
}

foreach(var nome in nomesLista)
{
  Console.WriteLine(nome);
}