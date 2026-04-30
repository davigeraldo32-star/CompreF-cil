namespace CompreFácil.Models
{
    
public class Gerenciador
    {
        public int Id {get; set;}
        public required string Produto {get; set;}
        public required string Descricao {get; set; }
        public required string Status {get; set;} = "Aberto";
        public DateTime DataPedido {get; set; } = DateTime.Now;
        public DateTime? DataFinal {get; set;} 
    }
}
