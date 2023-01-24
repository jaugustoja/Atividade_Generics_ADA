using Generics.Models;

//Instancia o objeto dicionario.
Dicionario dicionario1 = new Dicionario();

//Método que carrega o arquivo dicionario.txt da pasta com as chaves e valores salvos do dicionario.
dicionario1.CarregarDados();


//Método que adiciona os termos e descrições ao dicionário para que fique salvo e depois seja carregado ao reiniciar a aplicação.

// dicionario1.AdicionarTermos("chocolat", "chocolate");
// dicionario1.AdicionarTermos("water", "agua");
// dicionario1.AdicionarTermos("pencil", "caneta");

//Faz a busca dos termos no dicionario.
dicionario1.buscarTermos("OC");

//Método que salva os termos e descirções adicionados no dicionário em arquivo externo (dicionario.txt)
dicionario1.SalvarDados();

