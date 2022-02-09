using System;

namespace Renda_do_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario("joao", "999", 2.500, DateTime.Parse("2020-01-01"), "111.111.111.52");





            Console.WriteLine($"Nome  {f.Nome} \n matricula  {f.Matricula} \n  salario {f.Salario} \n  salario mensal {f.CalcularGanhoLiquidoMensal()} \n" +
                $"  salario anual {f.CalcularGanhoBrutoAnual()} \n  salario imposto pago em ano {f.CalcularImposto()}");
        }
                public class Funcionario
        {
            public string Nome { get; set; }

            public string Matricula { get; set; }

            public double Salario { get; set; }

            public DateTime DataAdmissao { get; set; }

            public string Cpf { get; set; }


            public Funcionario(string nome, string matricula, double salario, DateTime dataAdimisao, string cpf)
            {
                this.Nome = nome;
                this.Matricula = matricula;
                this.Salario = salario;
                this.DataAdmissao = dataAdimisao;
                this.Cpf = cpf;
            }


            public void ReceberAumento(double aumento)
            {
                this.Salario += aumento;
            }


            public double CalcularGanhoBrutoAnual()
            {

                if (DataAdmissao.Month == 12)
                {
                    return Salario * 12;
                }
                else
                {
                    return Salario * (12 - DataAdmissao.Month);
                }
            }

            public double CalcularImposto()
            {

                int TempoTotalTrabalhado = 0;
                double SalarioTotal = 0;

                if (DataAdmissao.Month == 12)
                {
                    SalarioTotal = this.Salario * 12;
                }
                else
                {
                    SalarioTotal = this.Salario * (12 - DataAdmissao.Month);
                }


                if (this.Salario > 2.500) // 17,5%
                {
                    return (SalarioTotal * 0.175);
                }

                return (SalarioTotal * 0.11);
            }


            public double CalcularGanhoLiquidoMensal()
            {

                if (this.Salario > 2.500) // 17,5%
                {
                    return this.Salario - (this.Salario * 0.175);
                }
                else
                {
                    return this.Salario - (this.Salario * 0.11);  //11%
                }

            }

            public double CalcularGanhoLiquidoAnual()
            {
                int TempoTotalTrabalhado = 0;
                double SalarioTotal = 0;

                if (DataAdmissao.Month == 12)
                {
                    SalarioTotal = this.Salario * 12;
                }
                else
                {
                    SalarioTotal = this.Salario * (12 - DataAdmissao.Month);
                }



                if (this.Salario > 2.500) // 17,5%
                {
                    return SalarioTotal - (SalarioTotal * 0.175);
                }

                return SalarioTotal - (SalarioTotal * 0.11);
            }

        }
    }
 }

