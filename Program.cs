// Aluno aluno1 = new Aluno(
//     "Arthur Morgan",
//     "AL000001"
// );

// Livro livro1 = new Livro(
//     "Código Limpo",
//     "Robert C. Martin"
// );

// Emprestimo emprestimo1 = new Emprestimo( 
//     aluno1,
//     livro1,
//     new DateOnly(2026, 10, 07), 
//     new DateOnly(2026, 10, 14)
//     );

// emprestimo1.ExibirResumo();

Cliente cliente = new Cliente("Roberto", "0990909090");
Cliente cliente1 = new Cliente("Bárbara", "0707070707");

Veiculo veiculo = new Veiculo("Volkswagen T-Cross", "33333F");
Veiculo veiculo1 = new Veiculo("Fiat Strada", "545454G");

Locacao locacao = new Locacao(cliente, veiculo1, new DateOnly(2026, 10, 07), 4, 5);
Locacao locacao1 = new Locacao(cliente1, veiculo, new DateOnly(2026, 09, 02), 7, 10);

locacao.ExibirResumo();
Console.WriteLine();
locacao1.ExibirResumo();
