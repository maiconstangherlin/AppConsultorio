using System;

namespace Core.Shared.ModelViews
{
    /// <summary>
    /// Objeto utilizado para inserção de um novo cliente
    /// </summary>
    public class NovoCliente
    {
        /// <summary>
        /// Nome do cliente        
        /// </summary>
        /// <example>Juca Bala</example>
        public string Nome { get; set; }
        
        /// <summary>
        /// Data de nascimento do cliente
        /// </summary>
        /// <example>2000-01-01</example>
        public DateTime DataNascimento { get; set; }

        /// <example>F</example>
        public char Sexo { get; set; }
        
        /// <example>46988776655</example>
        public string Telefone { get; set; }

        /// <summary>
        /// Documento do cliente: CNH, CPF, RG
        /// </summary>
        /// <example>000111554487</example>
        public string Documento { get; set; }
    }
}
