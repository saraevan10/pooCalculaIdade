using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {

		public Pessoa(String nomePessoa, int anoNascimentoPessoa)  //Construtor
		{
			this.Nome = nomePessoa;
			this.AnoNascimento = anoNascimentoPessoa;
			this.CalcularIdade();
		}


		private int anoNascimento;  //variavel

		public int AnoNascimento  //propriedade
		{
			get { return this.anoNascimento;; }
			set { this.anoNascimento = value; }
		}

		private String nome; //variavel

		public String Nome //propriedade
		{
			get { return this.nome; }
			set { this.nome = value.ToUpper(); }
		}

		//Vamos melhorar
		private int idade; //variavel

		public int Idade  //propriedade
		{
			get {
				this.CalcularIdade();
				return this.idade; 
			} //pega o valor da propriedade e entrega para quem solicitar
		}


		public void ExibirDados() //método
		{
			Console.WriteLine("Nome: " + this.nome);
			Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
			this.CalcularIdade();
			Console.WriteLine("Idade: " + this.Idade);
		}

		private void CalcularIdade() // método
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			this.idade = ano - this.AnoNascimento;
		}
	}
}
