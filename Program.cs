class Demos_aula_2
{

  static void Demo2()
  {

  }
  static void Demo1()
  {
    int a = 5;
    Adicionar20(ref a);
    System.Console.WriteLine($"O valor de a é:{a}");
  }
  static void Adicionar20(ref int a)
  {
    a += 20;
  }

  static void AlterarNome(string[] nomes, string nome, string nomeNovo)
  {
    for (int i = 0; i < nomes.Length; i++)
    {
      if (nomes[i] == nome)
      {
        nomes[i] = nomeNovo;
      }
    }
  }

  static ref string LocalizarNome(string[] nomes, string nome)
  {
    for (int i = 0; i < nome.Length; i++)
    {
      if (nomes[i] == nome)
      {
        return ref nomes[i];
      }
    }
    throw new Exception("Nome não encontrado");
  }
  static void Main()
  {
    var nomes = new string[] { "josé", "Maria", "Ricardo", "Alice", "pedro" };
    System.Console.WriteLine($"Alista de nomes é: {string.Join(" , \n", nomes)}");

    System.Console.WriteLine("Digite o nome a ser substituído");
    var nome = System.Console.ReadLine();
    System.Console.WriteLine("Digite o nome novo nome");
    var nomeNovo = System.Console.ReadLine();

    ref var nomeAchado = ref LocalizarNome(nomes, nome);

    if (!string.IsNullOrWhiteSpace(nomeAchado))
    {
      nomeAchado = nomeNovo;
      System.Console.WriteLine($"Alista de nomes Alterada é: {string.Join(" , \n", nomes)}");
    }
    else{
      System.Console.WriteLine("Nome não encontrado");
    }



  }


}