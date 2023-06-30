using System;

namespace validacpf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite seu CPF(Apenas Números): ");
                string cpf = Console.ReadLine();

                cpf = RemoverCaracteresFormato(cpf);

                if (VerificarNumerosCPF(cpf) && ValidarCPF(cpf))
                {
                    Console.WriteLine("=================================================================");
                    Console.WriteLine("Você digitou um CPF válido!(Verifique se você só digitou números)");
                    Console.WriteLine("=================================================================");
                    break; // Sai do loop se o CPF for válido
                }
                else
                {
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("Erro. Por favor, digite novamente um CPF válido.");
                    Console.WriteLine("________________________________________________");
                }

                Console.WriteLine("Deseja sair? (Digite 'N' para sair ou 'ENTER' para tentar novamente)");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() == "N")
                {
                    break; // Sai do loop se a resposta for 'N'
                }
            }
        }


        static bool VerificarNumerosCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }

            foreach (char c in cpf)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        static bool ValidarCPF(string cpf)
        {
            if (!VerificarDigitosRepetidos(cpf))
            {
                return false;
            }

            int soma1 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma1 += (cpf[i] - '0') * (10 - i);
            }

            int resto1 = soma1 % 11;
            int digitoVerificador1 = resto1 < 2 ? 0 : 11 - resto1;

            if ((cpf[9] - '0') != digitoVerificador1)
            {
                return false;
            }

            int soma2 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma2 += (cpf[i] - '0') * (11 - i);
            }

            int resto2 = soma2 % 11;
            int digitoVerificador2 = resto2 < 2 ? 0 : 11 - resto2;

            if ((cpf[10] - '0') != digitoVerificador2)
            {
                return false;
            }

            return true;
        }

        static bool VerificarDigitosRepetidos(string cpf)
        {
            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[0])
                {
                    return true;
                }
            }

            return false;
        }

        static string RemoverCaracteresFormato(string cpf)
        {
            // Remove caracteres de formatação (pontos e hífen) do CPF
            string cpfSemFormato = cpf.Replace(".", "").Replace("-", "");

            return cpfSemFormato;
        }
    }
}