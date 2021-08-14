namespace Core.Shared.ModelViews
{
    public class NovoEndereco
    {
        ///<example>85501500</example>
        public int Cep { get; set; }
        ///<example>PR</example>
        public string Estado { get; set; }
        ///<example>Curitiba</example>
        public string Cidade { get; set; }
        ///<example>Rua do Governador</example>
        public string Logradouro { get; set; }
        ///<example>123</example>
        public string Numero { get; set; }
        ///<example>Apto 201</example>
        public string Complemento { get; set; }
    }
}