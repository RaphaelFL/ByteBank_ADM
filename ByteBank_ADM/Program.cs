using bytebank_ADM.Utilitario;
using ByteBank_ADM.Funcionarios;


Diretor funcPedro = new Diretor("123456789");
funcPedro.Nome = "Pedro malazartes";

Diretor DireRoberta = new Diretor("987654321");
DireRoberta.Nome = "Roberta malazartes";


Console.WriteLine(funcPedro.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(funcPedro);
gerenciador.Registrar(DireRoberta);

Console.WriteLine("Total de bonificação : " + gerenciador.TotalDeBonficacao);
Console.WriteLine("Total de bonificação : " + Funcionario.TotalDeFuncionarios);

funcPedro.AumentarSalario();
DireRoberta.AumentarSalario();