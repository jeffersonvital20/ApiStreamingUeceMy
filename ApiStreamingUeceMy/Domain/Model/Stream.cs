namespace ApiStreamingUeceMy.Domain.Model
{
    public class Stream
    {
        public Guid Id { get; set; }
        public string? Tipo { get; set; }
        public string? Link { get; set; }
        public byte[]? Arquivo { get; set; }
    }
}
